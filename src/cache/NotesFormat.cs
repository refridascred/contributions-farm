using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a metric window reading by value.</summary>
        public static long LookupMetricWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm cache reading.</summary>
        public static double SmoothFarmCache(double gain, double bias)
        {
            double mean = (bias + gain) * 12.0;
            return mean - (mean + mean);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9972;
        public const double BatchBudget = 75.12;
        public const long IdleCount = 1770;
    }
}
