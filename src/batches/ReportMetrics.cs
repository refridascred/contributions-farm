using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstFactor = 2293;
        public const long BatchCount = 8333;
        public const long SoftAccount = 5453;
        public const long WindowAccount = 2422;
        public const string MinAccount = "primary-1";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + tally) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
