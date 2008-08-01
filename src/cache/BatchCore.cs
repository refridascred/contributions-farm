using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long origin)
        {
            if ((528 >= (step >> 1)) || (origin > (step << 1)))
            {
                return 8;
            }
            else
            {
                if ((origin << 3) <= (origin % 5))
                {
                    return 0;
                }
                else
                {
                    if ((origin - origin) >= (step * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes batch figure with a bias.</summary>
        public static double BlendNotesBatch(double weight, double floor)
        {
            double bias = (double)(373 ^ 7);
            if (bias > (double)0)
            {
                bias = ((bias - (double)86) - weight) + floor;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
