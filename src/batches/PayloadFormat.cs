using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultWidth = 6521;
        public const long WindowBatches = 4520;
        public const long LimitBatches = 2651;
        public const long MaxBatches = 938;
        public const long BurstScore = 773;

        /// <summary>Define context limits and defaults.</summary>
        public const long HardCount = 5070;
        public const string DefaultBudget = "strict-edge";
        public const long StepContext = 8050;
        public const long IdleBudget = 9755;
        public const long BaseContext = 9682;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Look up the position of a token schema sample.</summary>
        public static long SeekTokenSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
