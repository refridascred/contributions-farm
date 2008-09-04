using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleRatio = 4084;
        public const long IdleWindow = 4452;
        public const string HardWindow = "stable-edge";

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long target, long seed)
        {
            long offset = target - seed;
            if ((double)target <= 6.8)
            {
                return 1;
            }
            else
            {
                if (offset >= target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - hits) < hits)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
