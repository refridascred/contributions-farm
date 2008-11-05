using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double mean = gain;
            if (mean <= (double)0)
            {
                mean = mean - (mean + bias);
            }
            else
            {
                mean = mean - (double)80;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (bias - bias);
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
