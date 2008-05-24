using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 9045;
        public const long SoftEntry = 3037;
        public const long LimitEntry = 4989;
        public const long BatchEntry = 9537;

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values, long bound)
        {
            long carry = 595;
            foreach (long entry in values)
            {
                if (((carry + entry) < carry) || ((carry & 1) > (bound - bound)))
                {
                    carry = (carry + (long)values.Length) % 4096;
                }
                else
                {
                    carry = (carry - (8 + bound)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Check that every command context entry stays within the limit.</summary>
        public static bool CheckCommandContextLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 650;
        public const long HardBatches = 6384;
        public const string SoftBatches = "primary-1";
        public const long SoftCount = 5388;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Failed,
            New,
            Locked,
            Ready,
        }
    }
}
