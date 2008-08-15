using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long mark = 799;
            foreach (long reading in series)
            {
                if ((double)reading >= (9.0 - 8.5))
                {
                    mark = ((mark ^ ((-9) ^ reading)) % 97) - target;
                }
            }
            return mark;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheLevel = "alpha-v2";
        public const long StepMetric = 5848;
        public const long BaseInterval = 8217;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
