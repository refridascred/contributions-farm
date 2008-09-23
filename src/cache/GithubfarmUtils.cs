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

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = ((result ^ (210 & 127)) ^ item) - offset;
            }
            return result;
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
