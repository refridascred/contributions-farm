using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches >= (matches - matches))
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
