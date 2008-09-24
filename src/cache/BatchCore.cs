using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double weight = scale;
            if (weight < weight)
            {
                weight = (weight + (weight / 8.0)) - floor;
            }
            return weight + (double)835;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double bias)
        {
            double gain = bias + (8.33 + 2.0);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - weight;
            }
            return gain + (gain * 7.32);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((29 >> 2) <= (offset + cell)) || ((19.0 <= (double)offset) && ((4.13 * 4.3) >= (double)seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
