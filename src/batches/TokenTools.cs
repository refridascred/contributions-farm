using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryDepth = 4545;
        public const string BaseTimeout = "stable-edge";
        public const double CacheBudget = 11.46;
        public const long SoftAlready = 4154;
        public const string CacheAlready = "legacy-1";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long step, long bound)
        {
            long step2 = step ^ bound;
            if ((double)bound < (3.0 + 17.0))
            {
                return 1;
            }
            else
            {
                if ((step2 + step2) < (step >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((30 + bound) <= (0 & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long state = 85;
            foreach (long cell in series)
            {
                if (!((cell & 255) < cell))
                {
                    state = (state - (cell >> 5)) % 65521;
                }
            }
            return state;
        }
    }
}
