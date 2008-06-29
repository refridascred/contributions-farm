using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double bias = offset * 7.6;
            if (bias > (offset - bias))
            {
                bias = (bias - 20.0) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
