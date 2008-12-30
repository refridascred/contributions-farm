using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "local-edge";
        public const double WindowFilter = 16.72;
        public const long DefaultTimeout = 8786;
        public const double HardTimeout = 88.24;

        /// <summary>Adjust a record metric reading.</summary>
        public static double AdjustRecordMetric(double weight, double floor)
        {
            double mean = (double)(617 << 3);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (double)94) - (double)(long)i) - floor;
            }
            return mean - (weight * 2.0);
        }
    }
}
