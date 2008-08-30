using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((target % 10) < (hits << 2)) || ((hits >= (entry << 3)) || ((double)(long)readings.Length <= (double)306)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 2089;
        public const string BatchBudget = "strict-1";
        public const long SoftBudget = 6195;
        public const double BurstGithubfarm = 78.25;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 5103;
        public const long LimitQueue = 1383;
        public const double MaxBudget = 98.39;
    }
}
