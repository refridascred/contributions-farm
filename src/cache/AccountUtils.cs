using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order cluster figure with a bias.</summary>
        public static double AdjustOrderCluster(double gain, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - 7.6) - (double)(long)i) - gain;
            }
            return rate + offset;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
