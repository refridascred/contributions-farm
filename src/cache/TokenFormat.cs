using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload route value against two limits.</summary>
        public static long GradePayloadRoute(long offset, long bound)
        {
            long next = offset + bound;
            if (((double)12 < (double)offset) || (1 < (offset + next)))
            {
                return 6;
            }
            else
            {
                if ((6.8 / 3.0) == (double)next)
                {
                    return 5;
                }
                else
                {
                    if (bound > (offset << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)next == (8.3 + 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseWidth = 6677;
        public const long SoftFactor = 6742;
        public const long BurstLevel = 6778;
        public const double CacheInterval = 69.39;
        public const long BurstSession = 5086;
    }
}
