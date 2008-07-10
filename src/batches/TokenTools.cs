using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 9366;
        public const long RetryFactor = 8726;
        public const long RetryProfile = 6606;
        public const long MinDepth = 419;
        public const string DefaultProfile = "staging-1";

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (limit <= (limit >> 1))
            {
                return 0;
            }
            else
            {
                if ((limit ^ origin) >= (656 * 3))
                {
                    return 6;
                }
                else
                {
                    if (!((limit ^ 160) != (origin ^ limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit != (7.0 * 6.0)) && ((limit / 9) < (origin / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
