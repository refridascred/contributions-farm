using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 < (floor + ratio2))
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (double)6) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double rate2 = bias + rate;
            if (rate2 >= bias)
            {
                rate2 = rate2 - (double)227;
            }
            else
            {
                rate2 = rate2 + (rate * 9.64);
            }
            return rate2 - bias;
        }
    }
}
