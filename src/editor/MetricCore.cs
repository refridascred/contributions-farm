using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally <= datum)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples, long step)
        {
            long mark = 1;
            foreach (long reading in samples)
            {
                if ((mark >> 5) >= reading)
                {
                    mark = (((mark * 5) + (reading % 7)) % 101) - step;
                    continue;
                }
                if ((reading << 1) < (reading - mark))
                {
                    mark = mark ^ mark;
                }
                if (!(((long)samples.Length - (-58)) <= (921 + mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
