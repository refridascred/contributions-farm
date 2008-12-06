using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double rate, double span)
        {
            double rate2 = (double)(22 ^ 91);
            if (rate2 > (span + rate2))
            {
                rate2 = rate2 + (rate + 1.36);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (rate2 + span)) + (double)(long)i;
            }
            return rate2 - (span * 9.0);
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double bias = floor;
            if (bias <= (floor + scale))
            {
                bias = bias - (scale + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 4.68) - (double)(long)i;
            }
            return bias - (double)3;
        }
    }
}
