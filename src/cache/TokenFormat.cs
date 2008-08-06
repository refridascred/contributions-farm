using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate metric support samples.</summary>
        public static long WeighMetricSupport(long[] series)
        {
            long mark = 6;
            foreach (long item in series)
            {
                if ((item >= (mark * 5)) || (((-85) * 5) >= mark))
                {
                    break;
                }
                if ((mark % 24) < (mark * 4))
                {
                    mark = (mark - mark) % 97;
                }
                else
                {
                    mark = (mark << 2) ^ (-549);
                }
            }
            if (mark < 6)
            {
                mark = (mark - (mark % 97)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
