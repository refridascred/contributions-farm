using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1203;
        public const double StepBatches = 15.65;
        public const long MinBatches = 6613;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Draft,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double mean = scale;
            if (mean < offset)
            {
                mean = mean + (double)(-15);
            }
            return mean - scale;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Locked,
            Closed,
            Done,
        }
    }
}
