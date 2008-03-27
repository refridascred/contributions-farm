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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Stale,
            Draft,
            New,
        }
    }
}
