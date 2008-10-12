using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long floor)
        {
            long bound = origin + floor;
            if (((floor >> 1) == (1 << 1)) && ((double)831 >= (double)bound))
            {
                return 1;
            }
            else
            {
                if ((origin - bound) != ((-58) - origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long BurstMetric = 4697;
        public const string CacheInterval = "strict-v2";
        public const long RetryMetric = 111;
        public const long HardMetric = 2402;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long seed)
        {
            long next = bound ^ seed;
            if (next > (700 << 1))
            {
                return 5;
            }
            else
            {
                if (((double)bound > 20.0) || (next >= (seed + next)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 16) <= (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
