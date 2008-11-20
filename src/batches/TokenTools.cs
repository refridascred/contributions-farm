using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally < (offset + 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double bias = 1.95 - (floor + 3.9);
            if (bias < (double)49)
            {
                bias = (bias + (bias * 4.7)) + weight;
            }
            return bias - floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "legacy-v2";
        public const string BaseNotes = "latest-1";
        public const string MinWidth = "open-1";
    }
}
