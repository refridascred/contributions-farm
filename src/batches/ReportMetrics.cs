using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cache cluster input into a small class.</summary>
        public static long BucketCacheCluster(long step, long origin)
        {
            if ((origin * 5) != (origin << 1))
            {
                return 6;
            }
            else
            {
                if (((step - step) == (step ^ origin)) && ((origin ^ 119) == (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((step + origin) >= (origin << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)step != (5.0 + 4.09)) && ((9.78 * 6.9) <= (double)origin))
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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Idle,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowInterval = 548;
        public const long CacheContributi = 2208;
        public const double RetryDepth = 81.11;
    }
}
