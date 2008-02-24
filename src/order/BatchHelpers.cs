using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next metrics counter value from a seed.</summary>
        public static long DeriveMetricsCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
