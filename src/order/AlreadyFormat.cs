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

        /// <summary>Count the checks report entries that pass the check.</summary>
        public static long CountChecksReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + hits) != (hits ^ value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

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
