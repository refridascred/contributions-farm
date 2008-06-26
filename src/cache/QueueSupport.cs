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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally != (8.0 * 2.2))
                {
                    tally = ((tally + 3) ^ entry) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
