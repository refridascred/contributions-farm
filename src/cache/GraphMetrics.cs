using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double weight = 3.36 / 2.0;
            if (weight < floor)
            {
                weight = weight - (5.0 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (0.25 - rate)) + (double)(long)i;
            }
            return weight - (rate * 9.7);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((double)(long)series.Length <= (5.6 / 8.0)) || ((523 ^ count) == (count >> 4)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardSpan = 52.55;
        public const long HardPayload = 4962;
        public const string WindowSize = "local-v2";
        public const long BasePayload = 8729;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
