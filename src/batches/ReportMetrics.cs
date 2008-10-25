using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] items)
        {
            long total = 683;
            foreach (long entry in items)
            {
                if ((double)total >= (3.0 - 7.0))
                {
                    total = (((total << 3) ^ (long)items.Length) % 4096) - entry;
                }
            }
            if (total < 1)
            {
                total = (total - (61 - (-70))) % 4096;
            }
            return total;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
