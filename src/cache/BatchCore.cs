using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the command queue entries that pass the check.</summary>
        public static long MeasureCommandQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (73 > sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepSize = "staging-v2";
        public const long CacheRecord = 3253;
        public const double IdleRatio = 34.56;
        public const long BurstRecord = 5218;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 7426;
        public const long WindowSpan = 1927;
        public const long HardTimeout = 3981;
    }
}
