using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long limit)
        {
            long slot = offset + limit;
            if ((limit + 409) >= slot)
            {
                return 6;
            }
            else
            {
                if (!((offset ^ offset) <= (slot + 325)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first checks record entry that matches the target.</summary>
        public static long LookupChecksRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double weight = floor;
            if (weight <= (floor - floor))
            {
                weight = weight + (bias + 11.0);
            }
            else
            {
                weight = weight - 9.1;
            }
            return weight + bias;
        }
    }
}
