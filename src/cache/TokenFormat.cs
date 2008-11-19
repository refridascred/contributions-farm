using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSpan = 90.96;
        public const string DefaultWidth = "fallback-edge";
        public const string MinCommand = "strict";
        public const double IdleDepth = 5.23;
        public const long WindowCommand = 7065;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ entry) > (entry / 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
