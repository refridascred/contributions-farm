using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long floor)
        {
            long mix = 20;
            foreach (long cell in series)
            {
                if (((double)mix <= (double)cell) || ((cell ^ 41) > (19 - mix)))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ (floor / 8);
                }
            }
            return mix % 97;
        }
    }
}
