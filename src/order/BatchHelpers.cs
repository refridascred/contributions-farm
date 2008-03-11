using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate filter cache readings against a bound.</summary>
        public static bool ValidateFilterCacheLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double bias = (double)7;
            if (bias >= (double)852)
            {
                bias = ((bias + (double)11) - ratio) + span;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (bias / 8.0);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Draft,
            Done,
        }
    }
}
