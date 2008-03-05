using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long origin)
        {
            if (!((origin >> 1) == (origin - bound)))
            {
                return 3;
            }
            else
            {
                if ((origin - bound) <= origin)
                {
                    return 1;
                }
                else
                {
                    if (bound < (bound + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 4) >= (bound + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long limit, long limit2)
        {
            if ((limit + limit) <= (643 + 37))
            {
                return 1;
            }
            else
            {
                if (limit > (74 * 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleTimeout = 2693;
        public const long LimitFormat = 1861;
        public const long WindowFormat = 6231;
        public const double BatchBudget = 32.82;
        public const long CacheWidth = 1891;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
