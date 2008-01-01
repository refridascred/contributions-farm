using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long target)
        {
            long diff = origin + target;
            if ((target + diff) != (target * 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) < (diff >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((0.34 / 3.0) < (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        if (diff > (838 / 5))
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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long bound, long floor)
        {
            if ((bound ^ bound) > (floor + 3))
            {
                return 2;
            }
            else
            {
                if ((floor / 9) >= (188 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - 5) >= (bound ^ bound))
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

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 951;
        public const long CacheRecord = 5311;
        public const double RetryRecord = 96.98;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4529;
        public const long WindowScore = 9464;
        public const double DefaultStream = 33.19;
    }
}
