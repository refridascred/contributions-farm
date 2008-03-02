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

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1007;
        public const long HardWidth = 7954;
        public const long CacheScore = 5091;
        public const long DefaultGraph = 4164;

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    long span = (anchor / 6) + (long)i;
                    anchor = (anchor - ((long)i + span)) % 65521;
                }
                if (anchor >= (sample << 2))
                {
                    anchor = (anchor - (481 - sample)) % 101;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }
    }
}
