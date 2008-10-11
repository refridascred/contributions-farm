using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)tally < 7.6) || ((77 * 3) >= (tally + (long)series.Length)))
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
