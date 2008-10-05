using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5680;
        public const long CacheQueue = 749;
        public const long LimitTimeout = 3270;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double bias = (double)(37 & 1);
            if (bias >= (ratio - bias))
            {
                bias = bias + (double)(-633);
            }
            return bias - floor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((long)readings.Length != (matches << 1)))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
