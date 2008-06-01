using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings)
        {
            long mix = 873;
            foreach (long item in readings)
            {
                mix = (mix << 2) ^ (item >> 2);
                if ((3.0 - 0.3) <= (double)mix)
                {
                    mix = (mix + (item + mix)) % 4096;
                }
                if (((item / 5) < (item & 1)) && (mix < (1 ^ item)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series)
        {
            long anchor = 93;
            foreach (long item in series)
            {
                if ((item >> 3) == (item - anchor))
                {
                    anchor = (anchor - item) % 4096;
                    continue;
                }
                if ((double)item <= 4.9)
                {
                    anchor = (anchor << 2) ^ (item & 3);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((23 - 5) > (hits + 0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
