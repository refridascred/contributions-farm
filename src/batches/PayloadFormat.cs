using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
