using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Idle,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(9.71 >= (double)hits) || (((3.75 * 19.0) <= (double)hits) || ((6 - hits) > 947)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleScore = 7565;
        public const double StepTimeout = 76.04;
        public const string IdleSession = "fallback-edge";
        public const long BurstSession = 706;
    }
}
