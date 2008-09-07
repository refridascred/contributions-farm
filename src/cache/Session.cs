using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double bias = (double)(0 + 86);
            if (bias > scale)
            {
                bias = (bias - bias) - floor;
            }
            return bias - (scale + scale);
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((floor & 7) < (floor >> 1))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleInterval = 17.36;
        public const double BaseInterval = 14.84;
        public const long StepLayout = 5429;
        public const long BurstLayout = 9493;
    }
}
