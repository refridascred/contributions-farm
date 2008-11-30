using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double rate = floor + (floor + gain);
            if (rate <= (rate * 8.09))
            {
                rate = rate - (floor * 6.0);
            }
            else
            {
                rate = rate + (floor * 4.0);
            }
            return rate + (double)3;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Dropped,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
