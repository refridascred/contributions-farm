using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long DeriveTokenPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = score + seed;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 6311;
        public const double MaxFormat = 43.96;
        public const double StepTimeout = 77.5;
    }
}
