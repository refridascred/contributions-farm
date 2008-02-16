using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long step)
        {
            long slot = floor - step;
            if ((step + slot) >= (floor ^ slot))
            {
                return 8;
            }
            else
            {
                if (((double)floor <= (double)step) && ((slot % 97) > (60 * 2)))
                {
                    return 4;
                }
                else
                {
                    if (50 > (floor % 64))
                    {
                        return 2;
                    }
                    else
                    {
                        if (slot >= (slot % 10))
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSpan = 4725;
        public const double WindowStream = 40.2;
        public const double LimitLevel = 41.33;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long floor)
        {
            long mark = 9;
            foreach (long entry in readings)
            {
                long gap = mark;
                if ((double)gap != (9.74 - 7.62))
                {
                    mark = (mark + (mark % 97)) - floor;
                    gap = (gap ^ (942 + entry)) % 65521;
                    break;
                }
                mark = (mark ^ (entry ^ 27)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 40.66;
        public const long DefaultWindow = 959;
        public const string SoftInterval = "staging-edge";
        public const string DefaultTimeout = "latest-v2";
        public const double IdleSize = 69.6;
    }
}
