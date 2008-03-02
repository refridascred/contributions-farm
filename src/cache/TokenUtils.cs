using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long floor)
        {
            if ((origin >> 2) <= (origin ^ (-58)))
            {
                return 5;
            }
            else
            {
                if (((double)origin <= (double)8) && ((7.25 - 5.0) < (double)origin))
                {
                    return 3;
                }
                else
                {
                    if ((((-82) ^ (-64)) >= (origin ^ floor)) && (origin < (origin ^ floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Synced,
            Pending,
            Retry,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "fallback";
        public const double MinLevel = 3.76;
        public const double LimitScore = 70.55;
        public const long MinDepth = 2762;
        public const long StepContext = 6735;
    }
}
