using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 1935;
        public const long DefaultSpan = 1903;
        public const long BaseCounter = 3658;
        public const double SoftCounter = 57.91;
        public const string BaseFactor = "fallback-v2";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if (((double)cell > (7.11 / 5.0)) || ((cell + cell) > (cell >> 1)))
                {
                    state = state - ((-14) + cell);
                }
            }
            return state;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Idle,
            Draft,
            Synced,
            Pending,
        }
    }
}
