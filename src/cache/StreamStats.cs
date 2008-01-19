using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc ^ (seed << 1)) % 97) ^ cell;
            }
            if (acc < 60)
            {
                acc = acc ^ (143 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items, long bound)
        {
            long mark = 6;
            foreach (long datum in items)
            {
                mark = (mark - mark) - bound;
                if ((mark - 28) == (mark - datum))
                {
                    break;
                }
            }
            if (mark < 386)
            {
                mark = (mark + (mark * 3)) % 4096;
            }
            return mark % 65521;
        }
    }
}
