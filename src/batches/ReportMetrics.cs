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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total + (total - entry)) % 1000) + (long)i;
                }
                if ((entry + total) < (entry % 8))
                {
                    total = ((total * 3) + total) % 65521;
                }
            }
            return total % 4096;
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
