using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleBudget = 6459;
        public const long IdleProfile = 1824;
        public const double DefaultProfile = 12.85;
        public const long RetryLevel = 4501;
        public const long WindowCount = 7603;

        /// <summary>Audit queue entry readings against a rule.</summary>
        public static long CountQueueEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + matches) < (value << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
