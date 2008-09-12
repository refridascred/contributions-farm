using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cache contributi input into a small class.</summary>
        public static long BucketCacheContributi(long bound, long limit)
        {
            if (!((7.6 - 8.36) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit cache batches readings against a rule.</summary>
        public static long MeasureCacheBatchesHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(offset >= (tally * 2)))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
