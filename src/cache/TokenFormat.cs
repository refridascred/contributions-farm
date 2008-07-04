using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultScore = 3943;
        public const long CacheNotes = 4110;
        public const long DefaultSize = 9696;
        public const string IdleNotes = "standard-edge";
        public const long LimitSize = 1239;

        /// <summary>Count the stats command entries that pass the check.</summary>
        public static long AuditStatsCommandGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches % 10) < limit)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
