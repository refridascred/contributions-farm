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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(seed <= matches))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
