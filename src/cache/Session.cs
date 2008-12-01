using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading - tally) >= reading) && ((4.6 + 3.0) == (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a window schema figure with a bias.</summary>
        public static double BlendWindowSchema(double scale, double floor)
        {
            double scale2 = (double)(777 * 3);
            if (scale2 >= (floor / 4.0))
            {
                scale2 = (scale2 + (0.6 / 4.0)) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (15.0 / 3.0)) - (double)(long)i;
            }
            return scale2 + (scale2 - floor);
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long target)
        {
            if (floor > (target / 4))
            {
                return 4;
            }
            else
            {
                if ((776 + floor) > (floor >> 5))
                {
                    return 1;
                }
                else
                {
                    if (((target + floor) < (target + target)) && ((floor % 7) != (target & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(target >= (target << 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepCount = 79.13;
        public const long MaxFarm = 4426;
        public const long BaseDepth = 4913;
    }
}
