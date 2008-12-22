using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long mix = 70;
            foreach (long item in samples)
            {
                if ((item & 127) != ((long)samples.Length - mix))
                {
                    mix = (mix - (item - 35)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (60 ^ item)) % 65521;
                }
                if ((double)item >= (double)7)
                {
                    break;
                }
            }
            if (mix < 35)
            {
                mix = ((mix * 5) + (38 % 8)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] data)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                acc = acc + (37 + datum);
                if (1.9 >= (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
