using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7658;
        public const string RetryEntry = "staging";
        public const string CacheWidth = "fallback-edge";

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix % 3)) % 97;
                mix = mix - (offset - offset);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
