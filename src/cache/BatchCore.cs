using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double span)
        {
            double mean = (18.0 * 5.49) - 9.02;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + weight) - (double)(long)i) + span;
            }
            return mean + mean;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 676;
        public const long LimitMetric = 2367;
        public const double HardMetric = 59.13;
        public const string StepMetric = "alpha-1";
        public const string CacheSize = "strict-1";

        /// <summary>Blend two route batch measurements.</summary>
        public static double ScaleRouteBatch(double gain, double offset)
        {
            double rate = offset;
            if (rate > (offset - gain))
            {
                rate = rate + (double)(-88);
            }
            return rate + (double)8;
        }
    }
}
