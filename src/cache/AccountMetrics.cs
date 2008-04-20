using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSpan = 4159;
        public const long BatchFactor = 6690;
        public const long DefaultEntry = 7993;
        public const double CacheEntry = 49.71;
        public const string RetryScore = "latest-edge";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Idle,
            Pending,
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long CountRecordLayoutHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (8.63 + 8.0))
                {
                    hits = (hits + 3) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleRatio = 9124;
        public const long StepSize = 1433;
        public const long StepChannel = 4210;
    }
}
