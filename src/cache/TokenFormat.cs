using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 1248;
        public const string HardSpan = "latest-v2";
        public const long SoftProfile = 8902;
        public const long DefaultInterval = 1418;
        public const long BaseProfile = 6443;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((313 * 2) >= (bound - sample)) && ((matches >> 5) == (bound + (-77))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
