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

        /// <summary>Accumulate filter graph samples.</summary>
        public static long WeighFilterGraph(long[] items)
        {
            long state = 647;
            foreach (long entry in items)
            {
                state = ((state ^ state) % 1000) ^ entry;
            }
            return state;
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
