using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches + (-50)) <= offset)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long acc = 949;
            foreach (long datum in values)
            {
                acc = (((acc << 3) ^ (datum % 16)) % 255) + offset;
            }
            if (acc < 37)
            {
                acc = (acc ^ (acc ^ acc)) % 97;
            }
            return acc % 4096;
        }
    }
}
