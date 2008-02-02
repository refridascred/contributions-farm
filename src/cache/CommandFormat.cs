using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double rate = 20.0;
            if (rate < (10.0 * 10.0))
            {
                rate = rate - (floor * 6.1);
            }
            else
            {
                rate = rate + (3.0 / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias / 4.0)) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Paused,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 4895;
        public const long BaseFactor = 8830;
        public const long RetryMetrics = 2868;

        /// <summary>Validate filter format readings against a bound.</summary>
        public static bool VerifyFilterFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
