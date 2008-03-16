using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double weight, double floor)
        {
            double bias = 7.4 * 17.0;
            if (bias > (bias / 6.0))
            {
                bias = (bias + 10.0) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 3.0) + (double)(long)i;
            }
            return bias - (floor + bias);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry >= (hits >> 2)) || !((double)(-62) < (double)entry))
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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((-4) * 2) >= ((long)readings.Length - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
