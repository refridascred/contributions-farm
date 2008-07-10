using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long offset)
        {
            if (((58 + seed) > (offset + 303)) && (37 < seed))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (5.86 + 8.25))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-edge";
        public const long StepRoute = 7195;
        public const long MinSpan = 8729;
        public const long MaxScore = 487;
        public const double WindowRoute = 38.12;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a checks command value against two limits.</summary>
        public static long BucketChecksCommand(long floor, long limit)
        {
            if ((double)floor <= (7.25 * 9.0))
            {
                return 4;
            }
            else
            {
                if (((-30) * 5) <= (floor ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
