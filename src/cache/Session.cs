using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length >= 3)
                {
                    seen = ((seen + 3) ^ cell) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                total = total - (total - total);
                total = (total ^ cell) % 255;
            }
            return total;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
