using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Flag { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] series)
        {
            long mark = 43;
            foreach (long datum in series)
            {
                if ((datum - datum) > (mark / 6))
                {
                    mark = mark ^ (datum - mark);
                }
            }
            return mark;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)origin >= (15.0 - 9.1))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
