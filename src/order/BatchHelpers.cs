using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double rate, double span)
        {
            double bias = 1.9;
            if (bias > (double)1)
            {
                bias = (bias - bias) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (span - 8.0)) + (double)(long)i;
            }
            return bias - 0.29;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
