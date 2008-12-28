using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchRatio = 8632;
        public const long DefaultEntry = 4363;
        public const double MaxEntry = 65.88;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 11.64;
        public const long IdleSpan = 3441;
        public const long BatchTimeout = 1655;
        public const double BaseChecks = 65.83;
        public const long IdleChecks = 233;

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double offset)
        {
            double rate = offset;
            if (rate < scale)
            {
                rate = rate + (rate / 2.0);
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
