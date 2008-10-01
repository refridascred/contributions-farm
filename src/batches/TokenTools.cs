using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit <= sample) || ((double)seen >= 8.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series)
        {
            long mark = 947;
            foreach (long datum in series)
            {
                mark = (mark - (mark + datum)) % 4096;
                mark = (mark ^ mark) % 101;
            }
            return mark % 65521;
        }
    }
}
