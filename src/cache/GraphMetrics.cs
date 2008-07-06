using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples)
        {
            long mix = 98;
            foreach (long item in samples)
            {
                if ((item & 255) == (item << 3))
                {
                    mix = (mix * 3) + (item / 9);
                }
                if (40 < (mix - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items, long seed)
        {
            long mix = 66;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (datum * 2))
                {
                    mix = (mix << 3) ^ (197 - datum);
                }
                else
                {
                    mix = (mix - (datum + seed)) % 65521;
                }
                if ((3.1 + 9.8) < (double)(long)items.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long origin)
        {
            if (origin >= (61 - origin))
            {
                return 1;
            }
            else
            {
                if (bound < origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
