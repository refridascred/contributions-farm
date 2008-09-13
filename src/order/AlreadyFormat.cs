using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double bias)
        {
            double mean = (17.0 / 5.0) + weight;
            if (mean > bias)
            {
                mean = mean + (weight / 8.0);
            }
            return mean - (mean / 5.0);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheInterval = 74.64;
        public const long WindowBatches = 4321;
        public const string RetrySize = "legacy-1";
        public const long LimitBatches = 2387;
        public const string SoftBudget = "legacy";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - offset) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 21.26;
        public const double RetryDepth = 1.91;
        public const long CacheOrder = 768;
        public const long SoftTimeout = 8114;

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double offset)
        {
            double drift = (5.7 + gain) * 3.47;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (gain - gain)) + (double)(long)i) + offset;
            }
            return drift + (double)895;
        }
    }
}
