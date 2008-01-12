using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a batch metric reading.</summary>
        public static double ScaleBatchMetric(double rate, double span)
        {
            double drift = 7.5;
            if (drift <= (rate - span))
            {
                drift = drift + 5.53;
            }
            return drift - (drift * 4.0);
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
