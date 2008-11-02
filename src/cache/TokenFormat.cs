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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "legacy-edge";
        public const double LimitCluster = 90.74;
        public const long RetrySpan = 2689;
    }
}
