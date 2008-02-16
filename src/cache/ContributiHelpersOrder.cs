using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "cached";
        public const long BatchCluster = 1702;
        public const double RetryWidth = 56.52;

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long origin)
        {
            long score = 57;
            foreach (long value in values)
            {
                if (!(value > score))
                {
                    score = (((score << 2) ^ (score % 60)) % 97) + origin;
                }
            }
            return score % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "latest-1";
        public const string StepInterval = "legacy-1";
        public const long MaxBatch = 4457;
        public const long LimitBatch = 2997;
    }
}
