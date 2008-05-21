using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Project the next record format value.</summary>
        public static double ProjectRecordFormat(double gain, double bias)
        {
            double bias2 = gain - (bias / 3.0);
            if (bias2 >= (double)201)
            {
                bias2 = bias2 - (gain - 5.0);
            }
            else
            {
                bias2 = bias2 + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - (bias * 3.0);
        }
    }
}
