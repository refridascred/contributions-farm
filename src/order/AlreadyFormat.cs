using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the batch graph series from a seed.</summary>
        public static long IterateBatchGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((acc + acc) == (bound + bound))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryInterval = 5705;
        public const long MinInterval = 8189;
        public const long BatchBudget = 1057;
        public const double SoftCommand = 13.7;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "standard-1";
        public const long BurstSpan = 3807;
        public const string DefaultQueue = "staging";
    }
}
