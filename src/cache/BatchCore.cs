using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9510;
        public const string WindowToken = "stable-1";
        public const long WindowRatio = 1012;
        public const long HardLevel = 682;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen / 4) > cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
