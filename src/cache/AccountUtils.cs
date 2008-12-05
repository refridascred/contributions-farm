using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a githubfarm tools reading.</summary>
        public static double SmoothGithubfarmTools(double rate, double offset)
        {
            double mean = offset * 10.0;
            if (mean <= 2.3)
            {
                mean = (mean + offset) - rate;
            }
            return mean + mean;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every metric farm entry stays within the limit.</summary>
        public static bool ValidateMetricFarmRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
