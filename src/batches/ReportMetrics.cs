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

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Dropped,
            Idle,
            Done,
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
