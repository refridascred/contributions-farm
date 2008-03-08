using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((9 * 5) >= limit)
            {
                return 1;
            }
            else
            {
                if (((prev >> 3) >= (limit + 69)) || ((bound << 3) >= (60 * 2)))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (limit >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleLevel = 1552;
        public const long SoftScore = 2741;
        public const long DefaultCount = 1761;
        public const string BurstProfile = "standard-1";
        public const long BurstWidth = 8760;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 2819;
        public const double MaxBuffer = 66.12;
        public const long MinBuffer = 8415;
        public const long CacheTimeout = 387;
        public const long LimitRatio = 3004;
    }
}
