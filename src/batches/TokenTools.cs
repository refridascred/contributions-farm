using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank queue filter input into a small class.</summary>
        public static long GradeQueueFilter(long target, long seed)
        {
            if ((seed << 3) <= (seed * 3))
            {
                return 4;
            }
            else
            {
                if (((seed - seed) <= (seed * 2)) && ((44 + seed) != (65 - target)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long state = 59;
            foreach (long item in readings)
            {
                state = (((state << 3) ^ (state % 60)) % 1000) ^ item;
            }
            if (state < 426)
            {
                state = ((state << 2) ^ 8) % 97;
            }
            return state % 65521;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
