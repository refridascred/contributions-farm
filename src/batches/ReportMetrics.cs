using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryBudget = 6440;
        public const string IdleCommand = "local";
        public const long BurstCommand = 4929;
        public const long DefaultSpan = 9894;
        public const long HardCommand = 1236;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value / 7) >= (value - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
