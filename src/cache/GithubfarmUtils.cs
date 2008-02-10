using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits < 3.6) || ((cell << 1) < (cell % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double rate = 3.0;
            if (rate <= (double)665)
            {
                rate = ((rate + (rate / 4.0)) - ratio) - bias;
            }
            return rate - (double)0;
        }

        /// <summary>Combine support order values into a single score.</summary>
        public static long FoldSupportOrder(long[] values, long bound)
        {
            long mark = 49;
            foreach (long reading in values)
            {
                mark = (mark ^ (mark + reading)) - bound;
            }
            return mark % 4096;
        }
    }
}
