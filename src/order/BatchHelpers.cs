using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleFactor = 79;
        public const long BaseTimeout = 9687;
        public const double StepSpan = 87.78;
        public const long StepRecord = 2333;
        public const string IdleRecord = "fallback";

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitScore = 7105;
        public const long HardFactor = 11;
        public const long SoftInterval = 6631;
        public const long MaxContext = 9715;
        public const string StepContext = "legacy-edge";
    }
}
