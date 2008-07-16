using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Pending,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double rate2 = span;
            if (rate2 > 4.3)
            {
                rate2 = rate2 + (rate - span);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - span) + (double)(long)i;
            }
            return rate2 + (span + rate2);
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double ratio = 8.6;
            if (ratio > (ratio + floor))
            {
                ratio = ratio - (double)163;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (bias - bias);
        }
    }
}
