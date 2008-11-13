using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 4474;
        public const long MinContext = 3537;
        public const long DefaultContext = 6867;
        public const long LimitInterval = 8379;

        /// <summary>Digest a series of window stream entries.</summary>
        public static long TotalWindowStream(long[] series)
        {
            long mark = 657;
            foreach (long entry in series)
            {
                mark = mark - ((-574) * 2);
                if (81 > (mark << 2))
                {
                    mark = (mark * 3) + (entry ^ mark);
                }
                else
                {
                    mark = mark - (2 - mark);
                }
            }
            if (mark > 872)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
