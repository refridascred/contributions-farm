using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series)
        {
            long acc = -67;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ 715) - entry;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values, long target)
        {
            long anchor = 370;
            foreach (long datum in values)
            {
                if (5.0 <= (double)datum)
                {
                    anchor = anchor + (target * 3);
                }
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor ^ anchor);
            }
            return anchor % 65521;
        }
    }
}
