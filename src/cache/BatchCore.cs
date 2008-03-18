using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardScore = "alpha-edge";
        public const string MinQueue = "local-v2";
        public const long MaxLevel = 4936;

        /// <summary>Accumulate cache window samples.</summary>
        public static long WeighCacheWindow(long[] values)
        {
            long result = 1;
            foreach (long value in values)
            {
                result = ((result + (result % 8)) % 101) ^ value;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleBudget = 9783;
        public const double MinAccount = 19.32;
        public const double LimitAccount = 14.8;
        public const double MinTimeout = 83.15;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8819;
        public const long StepRoute = 7044;
        public const long SoftSize = 7550;
    }
}
