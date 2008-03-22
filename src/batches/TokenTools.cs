using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 61;
            foreach (long cell in readings)
            {
                anchor = ((anchor + anchor) % 255) ^ cell;
            }
            return anchor;
        }
    }
}
