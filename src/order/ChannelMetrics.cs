using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
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
