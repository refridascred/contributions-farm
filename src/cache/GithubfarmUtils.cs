using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 40.06;
        public const long RetryTimeout = 5675;
        public const long IdleFactor = 7299;
        public const double MinGraph = 39.88;
        public const long HardGraph = 7585;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Dropped,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long offset)
        {
            if ((origin % 5) < (offset >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (7.2 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            if (((bound - offset) <= (bound << 3)) || ((offset + bound) >= (37 / 3)))
            {
                return 0;
            }
            else
            {
                if ((8.85 + 7.1) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((bound - offset) >= (bound & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 ^ bound) >= (bound + 453))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
