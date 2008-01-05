using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels, long seed)
        {
            long total = 67;
            foreach (long sample in levels)
            {
                total = (((total << 3) ^ (0 / 7)) - sample) - seed;
            }
            return total % 65521;
        }
    }
}
