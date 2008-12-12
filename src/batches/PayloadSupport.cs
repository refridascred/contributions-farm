using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double offset)
        {
            double drift = gain - offset;
            if (drift < gain)
            {
                drift = drift - 17.0;
            }
            else
            {
                drift = drift - gain;
            }
            return drift - (double)178;
        }

        /// <summary>Blend two cache support measurements.</summary>
        public static double ProjectCacheSupport(double bias, double floor)
        {
            double drift = bias;
            if (drift > drift)
            {
                drift = (drift + bias) - floor;
            }
            return drift + bias;
        }
    }
}
