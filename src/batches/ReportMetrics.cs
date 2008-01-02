using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((29 + floor) <= (lane >> 3))
            {
                return 2;
            }
            else
            {
                if ((10.0 + 6.0) < (double)lane)
                {
                    return 6;
                }
                else
                {
                    if ((4 - lane) <= (lane + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 5244;
        public const string CacheWidth = "open";
        public const long IdleSession = 8491;
        public const long MaxTimeout = 4473;
        public const long MinSession = 8603;
    }
}
