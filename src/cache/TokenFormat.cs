using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit command batch readings against a rule.</summary>
        public static long AuditCommandBatchGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item / 6) != (matches - item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
