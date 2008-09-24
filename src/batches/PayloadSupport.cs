using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double bias)
        {
            double drift = bias + 7.11;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinBudget = 37.54;
        public const long SoftQueue = 4692;
        public const double RetryQueue = 4.21;
        public const double CacheQueue = 71.94;
        public const long BatchFactor = 7885;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value > (offset << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
