using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            if ((seed2 % 5) >= (seed * 2))
            {
                return 8;
            }
            else
            {
                if (((seed + 5) < seed2) || ((seed2 + seed2) < seed))
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) < (seed2 & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.1 - 6.0) >= (double)seed2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepWidth = 2139;
        public const double RetryFilter = 23.76;
        public const long BurstCount = 4647;
        public const long BatchTimeout = 2056;

        /// <summary>Classify a commits format pair into a bucket.</summary>
        public static long BucketCommitsFormat(long target, long origin)
        {
            if (origin > (target - target))
            {
                return 7;
            }
            else
            {
                if ((double)origin > 12.0)
                {
                    return 8;
                }
                else
                {
                    if ((target % 97) <= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target < (double)origin) || ((target + 376) == (origin - target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
