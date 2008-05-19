using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a filter contributi figure with a bias.</summary>
        public static double ScaleFilterContributi(double rate, double bias)
        {
            double rate2 = (double)(6 + (-56));
            if (rate2 > rate)
            {
                rate2 = rate2 - (rate * 3.3);
            }
            else
            {
                rate2 = rate2 - bias;
            }
            return rate2 + (rate - 3.0);
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((5.25 / 7.0) > (double)cell) && ((tally + tally) < (tally / 5)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 43.5;
        public const long BaseBudget = 8625;
        public const long StepSession = 7587;
    }
}
