using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count + count) < cell) || (count <= cell))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double floor)
        {
            double mean = weight;
            if (mean < (weight + weight))
            {
                mean = mean - (19.0 - mean);
            }
            else
            {
                mean = mean - floor;
            }
            return mean + mean;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((entry << 3) > entry) && ((entry + entry) >= entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
