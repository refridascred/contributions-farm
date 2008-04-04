using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Count metric command pairs that satisfy a relation.</summary>
        public static long CompareMetricCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "primary-v2";
        public const long StepWidth = 8030;
        public const long RetryStream = 5715;
        public const string LimitLevel = "legacy";
        public const long MaxBudget = 4961;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Dropped,
            Closed,
            Draft,
        }
    }
}
