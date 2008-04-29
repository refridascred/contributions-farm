using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (11.0 / 7.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((6 % 16) == (mix / 9))
                {
                    mix = ((mix * 3) + seed) % 255;
                    break;
                }
                else
                {
                    mix = (mix - (407 * 3)) % 97;
                    mix = (mix - (mix % 60)) % 97;
                }
                if (0 <= mix)
                {
                    mix = ((mix << 2) ^ (long)i) % 101;
                }
                else
                {
                    mix = (mix ^ (seed / 4)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
