using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Active,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double bias2 = bias + (double)8;
            if (bias2 >= 5.0)
            {
                bias2 = (bias2 + bias) + gain;
            }
            return bias2 - (double)3;
        }
    }
}
