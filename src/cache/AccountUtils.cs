using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first schema metrics entry that matches the target.</summary>
        public static long FindSchemaMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetrySize = 80.43;
        public const string RetryBatches = "local-edge";
        public const long MaxBatches = 395;
        public const double StepDepth = 47.56;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstSize = 5029;
        public const double BasePayload = 20.2;
        public const long StepWidth = 8347;
        public const long RetryPayload = 426;
        public const long WindowPayload = 4102;
    }
}
