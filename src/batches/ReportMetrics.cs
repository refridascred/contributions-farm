using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next window entry value.</summary>
        public static double ProjectWindowEntry(double rate, double offset)
        {
            double load = rate / 8.0;
            if (load > offset)
            {
                load = load - rate;
            }
            else
            {
                load = load + (double)7;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load - 11.0;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double weight = floor;
            if (weight >= 6.0)
            {
                weight = weight - (floor - rate);
            }
            return weight - (weight - rate);
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
