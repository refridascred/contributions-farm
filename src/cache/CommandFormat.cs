using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double offset)
        {
            double mean = (ratio - ratio) + (offset * 17.0);
            if (mean >= mean)
            {
                mean = mean + (offset / 4.0);
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (mean / 9.0);
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double offset)
        {
            double gain = 13.0;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + (gain / 8.0)) - (double)(long)i) + ratio;
            }
            return gain + offset;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long anchor = 83;
            foreach (long cell in levels)
            {
                anchor = (anchor ^ (cell + 40)) % 255;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4931;
        public const double RetryToken = 74.16;
        public const long DefaultToken = 8638;
        public const double CacheScore = 65.06;
        public const long MaxRatio = 8870;
    }
}
