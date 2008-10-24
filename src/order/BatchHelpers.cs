using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the command stats series from a seed.</summary>
        public static long RollCommandStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double bias)
        {
            double bias2 = (double)0 / 7.0;
            if (bias2 < (double)282)
            {
                bias2 = ((bias2 + (double)(-1)) + weight) + bias;
            }
            return bias2 - 8.03;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 88.1;
        public const long HardBatch = 7451;
        public const string RetryLevel = "fallback-v2";
        public const long SoftBatch = 3380;
        public const long MaxInterval = 67;
    }
}
