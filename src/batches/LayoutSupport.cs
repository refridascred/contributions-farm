using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((7.0 / 8.0) >= (double)matches) && (datum < (matches >> 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double mean = 1.98 * 2.0;
            if (mean >= weight)
            {
                mean = mean + (mean / 2.0);
            }
            return mean + bias;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 7352;
        public const double StepBudget = 92.58;
        public const string BatchGraph = "standard-v2";

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long sum = 39;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ sum)) % 4096) - cell;
            }
            return sum;
        }
    }
}
