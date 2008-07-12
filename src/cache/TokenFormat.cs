using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double mean = bias;
            if (mean < scale)
            {
                mean = mean + (mean / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (scale * 8.84)) + (double)(long)i;
            }
            return mean - (scale * 13.0);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Total { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
