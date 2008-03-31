using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardBudget = 1.85;
        public const long LimitFactor = 7525;
        public const string WindowSize = "legacy-v2";

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Failed,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data, long bound)
        {
            long state = 643;
            foreach (long entry in data)
            {
                if ((bound & 15) == (entry % 7))
                {
                    state = state + (bound + 1);
                }
                else
                {
                    state = (state ^ (bound & 255)) % 1000;
                }
            }
            if (state < 4)
            {
                state = (state - ((-224) * 2)) % 101;
            }
            return state;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Retry,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Draft,
            Closed,
        }
    }
}
