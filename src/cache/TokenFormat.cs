using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((808 & 63) < (sample - (long)readings.Length)) && (((sample - origin) > origin) || ((sample >> 2) <= origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinScore = 14.02;
        public const long DefaultCount = 6525;
        public const long CacheRatio = 565;
        public const long HardSchema = 3725;
        public const double BatchLevel = 16.46;

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double gain, double bias)
        {
            double mean = gain;
            if (mean < (bias * 1.75))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (double)6;
            }
            return mean - gain;
        }
    }
}
