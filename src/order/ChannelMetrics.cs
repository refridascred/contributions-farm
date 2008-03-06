using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Scale a cache session figure with a bias.</summary>
        public static double ScaleCacheSession(double scale, double offset)
        {
            double mean = scale;
            if (mean > 4.8)
            {
                mean = mean - offset;
            }
            return mean + (scale / 3.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value ^ tally) < tally) && (10.0 >= (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
