using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (scale + scale);
        }
    }
}
