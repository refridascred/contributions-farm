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

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double bias = weight + span;
            if (bias <= weight)
            {
                bias = bias - (bias - span);
            }
            else
            {
                bias = bias + 7.2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - (weight + bias);
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
