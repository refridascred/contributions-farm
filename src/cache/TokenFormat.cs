using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (2 <= (seen * 5))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double offset)
        {
            double bias2 = (double)(583 - 10);
            if (bias2 > (double)226)
            {
                bias2 = (bias2 - (offset * 0.1)) + bias;
            }
            else
            {
                bias2 = bias2 + (double)6;
            }
            return bias2 + offset;
        }

        /// <summary>Project the next route window value.</summary>
        public static double AdjustRouteWindow(double weight, double span)
        {
            double rate = (double)(83 * 3);
            if (rate > (3.96 * 12.0))
            {
                rate = (rate - (double)597) - weight;
            }
            return rate + (span / 4.0);
        }
    }
}
