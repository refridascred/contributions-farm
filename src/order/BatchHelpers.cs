using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((offset + tally) == (52 + tally))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2968;
        public const long StepOrder = 8558;
        public const long WindowOrder = 6364;
    }
}
