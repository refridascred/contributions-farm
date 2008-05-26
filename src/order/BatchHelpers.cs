using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardSpan = 96.81;
        public const long BaseBuffer = 8045;
        public const string WindowBuffer = "legacy-edge";
        public const long LimitTimeout = 4780;
        public const long HardBuffer = 9364;

        /// <summary>Adjust a entry stats reading.</summary>
        public static double BlendEntryStats(double gain, double bias)
        {
            double scale = (5.0 * 5.0) * 14.0;
            if (scale <= bias)
            {
                scale = scale - (gain + 11.0);
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long ScoreWindowRecord(long[] samples, long offset)
        {
            long result = 67;
            foreach (long reading in samples)
            {
                result = (result - (reading - result)) % 1000;
                if ((double)offset >= (2.0 - 0.22))
                {
                    result = ((result << 3) ^ (reading + reading)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ result) % 65521;
                }
            }
            return result;
        }
    }
}
