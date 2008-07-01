using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)cell == (double)65))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
