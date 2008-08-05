using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!!((datum & 127) > (count >> 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Limit { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of metric farm entries.</summary>
        public static long WeighMetricFarm(long[] samples)
        {
            long mark = 88;
            foreach (long value in samples)
            {
                if (((value % 97) >= (mark + mark)) && (mark > (mark ^ mark)))
                {
                    mark = (mark << 3) ^ value;
                }
                mark = mark ^ (130 & 127);
                if (!((2.5 - 5.7) == (double)value))
                {
                    mark = ((mark << 3) ^ (value << 1)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long limit)
        {
            long total = 154;
            foreach (long reading in data)
            {
                total = (total * 3) + (limit ^ reading);
                total = (total ^ (total * 3)) % 65521;
                total = (total + (61 * 3)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long TallyFarmMetricsMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item < (3.4 * 5.65))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
