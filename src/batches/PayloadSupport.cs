using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
