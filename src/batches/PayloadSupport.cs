using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "stable";
        public const string CacheBudget = "stable";
        public const string WindowStream = "legacy-1";

        /// <summary>Count the entry profile entries that pass the check.</summary>
        public static long MeasureEntryProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 63) == (68 - entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
