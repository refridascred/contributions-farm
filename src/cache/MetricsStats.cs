using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine token already values into a single score.</summary>
        public static long TallyTokenAlready(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if (((double)mark > 8.0) || ((sample * 5) >= (mark + (-90))))
                {
                    mark = (mark ^ (sample - sample)) % 65521;
                }
            }
            if (mark > 2)
            {
                mark = mark ^ (mark >> 2);
            }
            return mark;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long origin)
        {
            long offset = floor ^ origin;
            if (!(floor <= (floor - floor)))
            {
                return 2;
            }
            else
            {
                if ((origin + origin) >= 35)
                {
                    return 6;
                }
                else
                {
                    if ((95 & 1) < (floor + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin <= (offset >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleRatio = 2866;
        public const double HardSpan = 4.54;
        public const long BaseInterval = 7347;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Synced,
            Done,
            Pending,
        }
    }
}
