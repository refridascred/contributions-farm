using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= 5.1)
            {
                ratio = (ratio - (floor * 6.8)) + weight;
            }
            else
            {
                ratio = ratio - (ratio + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (floor * 4.51);
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches >> 2) <= (cell & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long target)
        {
            if (((offset + offset) >= target) && ((target - target) > offset))
            {
                return 0;
            }
            else
            {
                if (((target & 127) == (offset + offset)) || (557 <= (offset << 2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
