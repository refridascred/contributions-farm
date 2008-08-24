using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a queue batches sample.</summary>
        public static long LookupQueueBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8294;
        public const double MinProfile = 16.7;
        public const long BurstProfile = 299;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 9602;
        public const long DefaultStream = 5512;
        public const long MaxCount = 9926;
        public const long LimitLevel = 187;
        public const long MaxFactor = 7660;

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double scale = (double)8 * 2.6;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale * 5.0)) + (double)(long)i) - weight) - bias;
            }
            return scale + (scale - 6.8);
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Idle,
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Count the filter profile entries that pass the check.</summary>
        public static long AuditFilterProfileOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally <= (floor + floor))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }
    }
}
