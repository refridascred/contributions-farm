using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a payload entry figure with a bias.</summary>
        public static double ScalePayloadEntry(double gain, double floor)
        {
            double ratio = 5.1;
            if (ratio <= 4.0)
            {
                ratio = (ratio + (double)337) - floor;
            }
            return ratio - gain;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long sum = 88;
            foreach (long datum in readings)
            {
                if ((8.0 / 4.0) < (double)datum)
                {
                    sum = sum - (datum + (long)readings.Length);
                    sum = (sum * 2) + datum;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum * 2) + (sum << 1)) % 4096) - (long)i;
                }
                sum = (sum * 5) + (601 * 2);
            }
            return sum;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
