using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRatio = 33.35;
        public const long RetrySpan = 9659;
        public const long MinRoute = 4451;
        public const string HardScore = "staging";
        public const long BaseDepth = 145;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Synced,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((37 / 9) >= bound)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Locked,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Paused,
            Idle,
        }
    }
}
