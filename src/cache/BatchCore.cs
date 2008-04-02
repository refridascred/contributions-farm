using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi cluster value from a seed.</summary>
        public static long DeriveContributiCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)floor >= 17.0)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items)
        {
            long total = 6;
            foreach (long sample in items)
            {
                if (total >= (sample * 3))
                {
                    total = (total * 4) + 662;
                }
            }
            if (total > 5)
            {
                total = (total * 3) + (total >> 3);
            }
            return total % 97;
        }
    }
}
