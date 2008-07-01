using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - 249) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepCount = 5095;
        public const double DefaultRatio = 48.01;
        public const double BatchBuffer = 21.61;
        public const long BurstInterval = 8604;
    }
}
