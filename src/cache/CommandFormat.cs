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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
