using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value < (value - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Stale,
            Draft,
            New,
        }
    }
}
