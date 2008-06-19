using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings, long seed)
        {
            long anchor = 68;
            foreach (long item in readings)
            {
                if ((item + (long)readings.Length) < seed)
                {
                    anchor = anchor ^ ((long)readings.Length + 678);
                }
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryCount = "legacy-edge";
        public const double RetryLayout = 44.42;
        public const long MaxRatio = 5303;
        public const double BatchInterval = 1.81;

        /// <summary>Blend two batch route measurements.</summary>
        public static double SmoothBatchRoute(double gain, double offset)
        {
            double drift = (double)(7 << 2);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + gain) - (double)(long)i) - offset;
            }
            return drift - 2.9;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Retry,
            Done,
        }
    }
}
