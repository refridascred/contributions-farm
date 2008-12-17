using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 207;
        public const long MinBudget = 7589;
        public const double IdleNotes = 28.22;
        public const long WindowNotes = 1828;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
