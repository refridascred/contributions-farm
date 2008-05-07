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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstSize = 5029;
        public const double BasePayload = 20.2;
        public const long StepWidth = 8347;
        public const long RetryPayload = 426;
        public const long WindowPayload = 4102;
    }
}
