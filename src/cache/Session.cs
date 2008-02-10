using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                if (!((9.69 + 3.0) >= (double)step))
                {
                    anchor = ((anchor << 2) ^ (cell + step)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (step * 4)) % 101;
                }
            }
            return anchor;
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
