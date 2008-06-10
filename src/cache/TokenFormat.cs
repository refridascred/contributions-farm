using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitWidth = 2967;
        public const long RetryEditor = 8536;
        public const long IdleEditor = 3725;
        public const double CacheScore = 91.67;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ 346;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double drift = (span + 3.2) + rate;
            if (drift > 8.94)
            {
                drift = drift - (drift + 2.2);
            }
            else
            {
                drift = drift - (rate * 9.8);
            }
            return drift + (8.2 * 9.44);
        }
    }
}
