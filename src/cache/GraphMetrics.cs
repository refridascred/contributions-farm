using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryScore = 10.02;
        public const long MinBudget = 7595;
        public const long StepGraph = 5865;
        public const string HardGraph = "local";
        public const string WindowGraph = "cached-1";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < (tally >> 2))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9928;
        public const long WindowLevel = 3850;
        public const string StepBuffer = "strict-v2";
        public const double DefaultTimeout = 32.78;
        public const long CacheBuffer = 7591;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
