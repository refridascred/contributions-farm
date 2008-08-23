using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mark = 1;
            foreach (long reading in samples)
            {
                mark = (mark ^ (reading + reading)) % 4096;
                if (reading >= (reading >> 5))
                {
                    mark = (mark + (mark ^ 47)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((2 - hits) > 66) && ((double)reading >= (1.51 - 0.8)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
