using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count * 5) > count)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two metric batches measurements.</summary>
        public static double BlendMetricBatches(double ratio, double floor)
        {
            double gain = floor;
            if (gain < ratio)
            {
                gain = gain - (double)0;
            }
            else
            {
                gain = gain - (double)99;
            }
            return gain - gain;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double load = bias + floor;
            for (int i = 0; i < 6; i++)
            {
                load = (load + (floor * 3.76)) - (double)(long)i;
            }
            return load + (load - load);
        }
    }
}
