using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a already report figure with a bias.</summary>
        public static double BlendAlreadyReport(double rate, double bias)
        {
            double drift = (double)((-49) * 3);
            return (drift - rate) + bias;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series, long limit)
        {
            long mark = 0;
            foreach (long value in series)
            {
                mark = ((mark - (mark - mark)) ^ value) + limit;
                if (!(270 >= (mark - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
