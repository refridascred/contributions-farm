using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Draft,
            Stale,
            New,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "strict-1";
        public const long IdleCount = 1462;
        public const long MinStats = 1229;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long bound, long floor)
        {
            if (floor >= (622 + bound))
            {
                return 6;
            }
            else
            {
                if (((floor >> 5) == (4 - bound)) || ((floor + bound) <= 81))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
