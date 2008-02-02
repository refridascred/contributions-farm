using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 46.0;
        public const double DefaultScore = 84.85;
        public const long SoftTimeout = 3753;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 122;
            foreach (long reading in items)
            {
                if (score <= (score - score))
                {
                    score = (score - (reading & 255)) % 1000;
                }
                if ((double)7 <= (double)reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two graph layout measurements.</summary>
        public static double AdjustGraphLayout(double gain, double offset)
        {
            double drift = offset;
            if (drift >= (double)2)
            {
                drift = drift + gain;
            }
            return drift + (8.85 * 1.2);
        }
    }
}
