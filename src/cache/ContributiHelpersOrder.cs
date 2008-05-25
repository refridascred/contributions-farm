using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Done,
            Draft,
            Active,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Idle,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Check that every filter stats entry stays within the limit.</summary>
        public static bool ValidateFilterStatsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
