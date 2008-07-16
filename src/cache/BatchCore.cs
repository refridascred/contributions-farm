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

        /// <summary>Blend two batch layout measurements.</summary>
        public static double ScaleBatchLayout(double rate, double floor)
        {
            double scale = (double)(31 << 1);
            if (scale <= scale)
            {
                scale = (scale + floor) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor / 6.0)) + (double)(long)i;
            }
            return scale + (double)77;
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
