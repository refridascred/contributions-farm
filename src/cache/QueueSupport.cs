using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a stream queue reading.</summary>
        public static double ProjectStreamQueue(double ratio, double floor)
        {
            double load = floor - floor;
            if (load >= ratio)
            {
                load = load + (ratio - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (5.0 / 5.0);
        }

        /// <summary>Grade a notes metrics value against two limits.</summary>
        public static long ClassifyNotesMetrics(long floor, long limit)
        {
            if (851 >= (158 + floor))
            {
                return 0;
            }
            else
            {
                if (!((1.83 / 2.0) > (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] readings)
        {
            long mix = 30;
            foreach (long reading in readings)
            {
                if ((reading & 31) <= (mix + reading))
                {
                    mix = ((mix * 4) + mix) % 1000;
                }
            }
            return mix;
        }
    }
}
