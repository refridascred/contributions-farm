using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of profile notes entries.</summary>
        public static long FoldProfileNotes(long[] levels, long floor)
        {
            long mark = 8;
            foreach (long value in levels)
            {
                mark = (mark - (floor / 5)) - value;
            }
            return mark;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
