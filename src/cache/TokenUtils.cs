using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] series)
        {
            long mark = 811;
            foreach (long cell in series)
            {
                mark = ((mark << 3) ^ (637 - mark)) + cell;
            }
            return mark % 97;
        }
    }
}
