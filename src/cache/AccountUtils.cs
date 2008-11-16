using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if ((10.0 < (double)reading) || ((4.68 + 20.0) >= (double)state))
                {
                    state = state ^ ((-3) + 5);
                }
            }
            if (state < 754)
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a cache entry figure with a bias.</summary>
        public static double SmoothCacheEntry(double bias, double span)
        {
            double mean = bias;
            if (mean <= (bias - bias))
            {
                mean = mean - (bias * 1.3);
            }
            else
            {
                mean = mean + (mean * 3.0);
            }
            return mean - span;
        }
    }
}
