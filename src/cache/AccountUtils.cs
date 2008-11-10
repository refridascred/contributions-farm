using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long offset, long floor)
        {
            if ((offset / 2) <= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor > 6.0)
                {
                    return 3;
                }
                else
                {
                    if (5 < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)floor > (3.16 - 0.36)) || ((offset + floor) > (floor >> 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double rate, double floor)
        {
            double mean = floor;
            if (mean <= mean)
            {
                mean = (mean + (1.67 / 7.0)) - rate;
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - value) >= (seed + 95))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
