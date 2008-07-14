using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (7.03 + 5.27))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] items)
        {
            long mark = 830;
            foreach (long reading in items)
            {
                if ((mark ^ mark) < (reading / 5))
                {
                    mark = ((mark * 3) + (reading >> 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of filter payload readings.</summary>
        public static long CompareFilterPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
