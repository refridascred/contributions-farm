using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if (!((903 % 97) >= (acc & 31)))
                {
                    acc = (acc << 3) ^ (item * 3);
                }
                else
                {
                    acc = ((acc * 4) + (0 % 16)) % 65521;
                }
                if ((6.9 - 5.0) <= (double)item)
                {
                    acc = (acc - (acc + item)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "fallback-v2";
        public const long CacheBuffer = 1153;
        public const long MaxBuffer = 5072;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
