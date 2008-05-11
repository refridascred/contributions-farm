using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheSize = 9152;
        public const string SoftRoute = "primary";
        public const long BatchRoute = 9313;
        public const string IdleRoute = "latest-v2";

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(((long)items.Length - cell) != (limit + limit)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Retry,
            Queued,
            Paused,
            Closed,
        }
    }
}
