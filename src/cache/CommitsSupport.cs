using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long seed)
        {
            if ((8.4 - 6.87) < (double)seed)
            {
                return 6;
            }
            else
            {
                if (!((-538) >= (seed & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((origin - origin) <= (seed + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            long delta = target ^ offset;
            if (((delta + 571) < (offset * 4)) || ((double)target < 4.58))
            {
                return 7;
            }
            else
            {
                if ((double)target <= 7.0)
                {
                    return 2;
                }
                else
                {
                    if (((offset ^ delta) < (42 + 609)) || ((double)target > (2.2 * 5.27)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6 << 3) <= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Dropped,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryTimeout = "open-edge";
        public const double CacheStats = 22.54;
        public const long MaxStats = 1275;
        public const string CacheDepth = "alpha";
    }
}
