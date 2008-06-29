using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Region { get; set; }
            public bool Size { get; set; }
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
