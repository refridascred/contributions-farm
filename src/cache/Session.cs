using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metrics commits pair into a bucket.</summary>
        public static long SortMetricsCommits(long origin, long floor)
        {
            if ((8.0 - 9.8) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor != (3.88 + 13.0))
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ origin) == (floor + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((546 << 1) >= (floor + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowScore = "cached-1";
        public const double WindowFilter = 18.11;
        public const long CacheCount = 5095;
        public const long IdleWidth = 416;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 6294;
        public const string BatchBudget = "cached-1";
        public const long RetrySpan = 7430;
    }
}
