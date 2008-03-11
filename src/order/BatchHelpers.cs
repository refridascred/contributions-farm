using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
