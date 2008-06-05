using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double bias = span + (ratio * 5.77);
            return bias - span;
        }

        /// <summary>Look up the position of a support checks sample.</summary>
        public static long LookupSupportChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Ready,
            New,
            Closed,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double gain, double floor)
        {
            double bias = gain + (gain - 6.3);
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (gain + floor)) + (double)(long)i;
            }
            return bias - (4.23 + floor);
        }
    }
}
