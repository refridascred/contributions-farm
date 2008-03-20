using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double load = bias * 5.5;
            if (load >= bias)
            {
                load = load + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)1) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 2810;
        public const double CacheWidth = 59.55;
        public const long HardSpan = 6547;
        public const double RetryCount = 52.43;
        public const long BaseSupport = 2389;
    }
}
