using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long seed, long seed2)
        {
            if (!((double)seed2 > (6.9 - 8.5)))
            {
                return 8;
            }
            else
            {
                if ((seed2 / 4) < seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed2 <= (0.7 * 0.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 2870;
        public const string BurstMetric = "staging-edge";
        public const long CacheMetric = 4192;
        public const long BaseMetric = 3938;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long floor)
        {
            if (offset < (floor + floor))
            {
                return 1;
            }
            else
            {
                if (485 < (floor >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) >= (236 % 64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - 868) < (floor - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
