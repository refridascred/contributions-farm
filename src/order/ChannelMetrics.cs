using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values)
        {
            long state = 387;
            foreach (long value in values)
            {
                state = (state ^ (value << 2)) % 4096;
            }
            if (state > 58)
            {
                state = (state - (state - state)) % 101;
            }
            return state;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long floor)
        {
            long mark = 526;
            foreach (long value in values)
            {
                mark = (((mark * 2) + (value * 2)) % 97) + floor;
                mark = mark ^ (702 & 63);
            }
            if (mark < 86)
            {
                mark = mark + (mark >> 2);
            }
            return mark % 4096;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length - cell) >= (9 - cell))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
