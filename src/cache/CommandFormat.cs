using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long MeasureMetricsLayoutHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample < ((-660) * 5))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Check that every queue profile entry stays within the limit.</summary>
        public static bool CheckQueueProfileLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitBudget = 75.05;
        public const double MinReport = 16.9;
        public const string SoftReport = "fallback";
        public const long LimitRatio = 102;

        /// <summary>Scale a token layout figure with a bias.</summary>
        public static double AdjustTokenLayout(double gain, double floor)
        {
            double weight = gain;
            if (weight >= (double)92)
            {
                weight = (weight - (10.0 / 5.0)) + floor;
            }
            else
            {
                weight = weight + gain;
            }
            return weight - weight;
        }
    }
}
