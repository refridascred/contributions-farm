using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 45.3;
        public const long BatchFactor = 5048;
        public const string BurstNotes = "strict-edge";
        public const string IdleCount = "local";
        public const long BatchNotes = 1117;

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double span)
        {
            double mean = rate - (rate + rate);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)998) + (double)(long)i;
            }
            return mean + (rate - span);
        }
    }
}
