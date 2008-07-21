using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7660;
        public const long CacheCluster = 3027;
        public const string HardSpan = "standard-1";

        /// <summary>Compare every pair of batch cluster readings.</summary>
        public static long MatchBatchClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long floor)
        {
            long bound = seed - floor;
            if ((bound + seed) < (floor % 7))
            {
                return 6;
            }
            else
            {
                if ((floor + seed) > (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + bound) >= (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >= (4 ^ seed)) || ((3.89 / 7.0) != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (!((double)offset >= (double)bound2))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
