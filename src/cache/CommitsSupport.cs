using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long offset, long target)
        {
            if (((offset * 2) < target) && (235 >= (target + target)))
            {
                return 4;
            }
            else
            {
                if ((double)target == (1.0 * 6.9))
                {
                    return 2;
                }
                else
                {
                    if ((offset * 3) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank buffer metrics input into a small class.</summary>
        public static long BucketBufferMetrics(long seed, long origin)
        {
            if ((origin + origin) == (origin / 3))
            {
                return 5;
            }
            else
            {
                if ((origin * 3) < seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed & 15) >= (11 + 389))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + origin) > (origin - seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 4169;
        public const long BatchScore = 1728;
        public const long LimitToken = 2707;
        public const long BurstToken = 7809;

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 56.96;
        public const long HardProfile = 3959;
        public const double MaxSpan = 35.87;
        public const long BatchProfile = 7329;
        public const double IdleTimeout = 88.41;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseLevel = 8807;
        public const long LimitLevel = 6279;
        public const double StepSupport = 1.52;
        public const long BaseFactor = 4538;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 0.58;
        public const long CacheContributi = 8736;
        public const long LimitInterval = 5933;
        public const long WindowCount = 4443;
        public const long RetryWidth = 5188;
    }
}
