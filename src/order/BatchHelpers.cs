using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 9760;
        public const double MaxSpan = 47.31;
        public const long StepEntry = 1588;
        public const string RetryEntry = "local";
        public const long WindowCount = 8327;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (7.0 < (double)(long)items.Length)
                {
                    tally = ((tally + 1) ^ datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double gain, double floor)
        {
            double rate = (double)(743 & 63);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (double)(long)i) + gain) + floor;
            }
            return rate - rate;
        }
    }
}
