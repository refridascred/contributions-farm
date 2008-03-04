using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Idle,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches > 8.85)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 4453;
        public const long LimitBudget = 7863;
        public const long CacheWidth = 9215;
        public const long RetryBudget = 9571;
        public const long IdleSpan = 6500;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 127) <= (offset + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
