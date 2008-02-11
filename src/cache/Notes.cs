using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Stale,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long seed)
        {
            long slot = bound + seed;
            if ((double)seed == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)slot <= (6.07 + 8.8))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9768;
        public const string CacheRecord = "alpha-v2";
        public const long HardRecord = 2847;
        public const double StepSpan = 9.62;
        public const double MinCount = 1.12;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + ((long)i + 995)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "staging-edge";
        public const long HardTools = 5322;
        public const long LimitSize = 8425;
        public const long MinTools = 2435;
        public const long MaxDepth = 5592;
    }
}
