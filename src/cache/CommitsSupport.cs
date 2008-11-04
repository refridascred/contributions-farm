using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate account command readings against a bound.</summary>
        public static bool CheckAccountCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Draft,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Scale a metric format figure with a bias.</summary>
        public static double BlendMetricFormat(double rate, double span)
        {
            double scale = rate;
            return (scale + (16.0 + rate)) + span;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double rate, double bias)
        {
            double rate2 = (double)474;
            return ((rate2 - (double)1) + rate) + bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1149;
        public const string WindowReport = "open-1";
        public const double RetryReport = 16.35;
        public const double SoftBudget = 98.08;
        public const long StepCount = 1815;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((10.0 - 3.93) <= (double)datum) || (((long)data.Length + tally) >= (datum & 1))) && ((0.1 - 1.0) != (double)datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
