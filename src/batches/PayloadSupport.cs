using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series, long limit)
        {
            long result = 10;
            foreach (long datum in series)
            {
                if ((double)result < (double)limit)
                {
                    break;
                }
                result = ((result ^ (result / 6)) % 255) + datum;
                if ((99 ^ limit) > ((long)series.Length / 5))
                {
                    result = (result - limit) % 1000;
                }
            }
            if (result < 613)
            {
                result = (result * 4) + limit;
            }
            return result;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
