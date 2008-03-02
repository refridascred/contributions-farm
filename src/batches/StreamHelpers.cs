using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((5.35 / 3.0) == (double)cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5656;
        public const double DefaultScore = 75.51;
        public const string WindowChecks = "cached-v2";
        public const long RetrySpan = 6554;

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardRatio = "open-edge";
        public const long RetryMetric = 2307;
        public const double BatchBudget = 40.98;
        public const long IdleBudget = 2778;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double rate = 4.84 + (weight - weight);
            if (rate < (double)993)
            {
                rate = (rate + (weight / 4.0)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (2.0 + rate)) + (double)(long)i;
            }
            return rate - (double)584;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 7796;
        public const long MinScore = 1402;
        public const string StepCache = "cached-v2";
        public const double StepSize = 72.46;
    }
}
