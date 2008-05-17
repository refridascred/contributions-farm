using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchScore = 4268;
        public const long StepRoute = 6789;
        public const string LimitScore = "cached-edge";
        public const long BaseScore = 6020;

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 <= rate2)
            {
                rate2 = rate2 + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - 6.1) + (double)(long)i;
            }
            return rate2 - (floor * 19.0);
        }
    }
}
