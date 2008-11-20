using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally < (offset + 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double bias = 1.95 - (floor + 3.9);
            if (bias < (double)49)
            {
                bias = (bias + (bias * 4.7)) + weight;
            }
            return bias - floor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length & 255) > (78 * 3))
                {
                    count = ((count + 1) ^ reading) - floor;
                }
            }
            return count;
        }
    }
}
