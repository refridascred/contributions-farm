using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema notes readings.</summary>
        public static long FoldSchemaNotes(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                if (origin >= (mark % 12))
                {
                    long diff = (long)samples.Length & 255;
                    mark = (mark ^ (diff >> 5)) % 255;
                }
                mark = ((mark * 2) + mark) % 1000;
                mark = (mark + reading) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "fallback-v2";
        public const double HardFilter = 6.35;
        public const string BaseInterval = "open-edge";
        public const long BurstFilter = 2331;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
