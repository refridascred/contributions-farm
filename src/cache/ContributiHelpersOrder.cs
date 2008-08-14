using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long SeekCachePayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route cache entry that matches the target.</summary>
        public static long LocateRouteCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream order value.</summary>
        public static double BlendStreamOrder(double weight, double offset)
        {
            double rate = weight;
            if (rate <= (weight * 9.22))
            {
                rate = (rate - weight) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)9) + (double)(long)i;
            }
            return rate + 7.94;
        }
    }
}
