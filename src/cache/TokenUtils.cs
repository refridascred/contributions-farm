using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long origin)
        {
            long acc = 90;
            foreach (long entry in data)
            {
                acc = acc ^ (579 ^ acc);
                acc = (acc << 2) ^ (entry + origin);
            }
            return acc;
        }
    }
}
