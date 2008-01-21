using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count > (5.74 * 0.26))
                {
                    count = ((count + 1) + value) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetrySpan = 4937;
        public const double BaseSpan = 3.06;
        public const long CacheCounter = 1476;
        public const long DefaultCounter = 8794;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= (70 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long target)
        {
            long cur = floor + target;
            if ((cur - cur) > (cur << 2))
            {
                return 4;
            }
            else
            {
                if (((target + floor) <= cur) || ((double)floor < (double)69))
                {
                    return 6;
                }
                else
                {
                    if ((target % 60) >= (floor + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((331 ^ floor) > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
