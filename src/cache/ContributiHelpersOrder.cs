using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (38 > (tally + tally))
                {
                    tally = (tally + 3) + value;
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
