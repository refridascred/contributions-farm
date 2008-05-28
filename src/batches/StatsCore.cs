using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool CheckFormatFarmBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(matches <= seed))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepBudget = 47.74;
        public const string DefaultInterval = "standard-edge";
        public const long RetryFormat = 6908;
        public const double LimitFormat = 26.8;
        public const long HardFormat = 9557;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 7390;
        public const double BatchInterval = 85.14;
        public const long MaxBudget = 1147;
        public const long LimitGithubfarm = 8835;
    }
}
