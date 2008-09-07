using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 1286;
        public const long BurstTimeout = 4117;
        public const double BaseBatches = 79.91;

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 34.51;
        public const long IdleSchema = 1901;
        public const double WindowFactor = 49.63;
        public const long MinScore = 7411;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 1273;
        public const long StepWidth = 1966;
        public const double SoftLayout = 35.39;
        public const double MaxBudget = 31.36;
        public const long SoftTimeout = 7818;

        /// <summary>Validate payload batch readings against a bound.</summary>
        public static bool ValidatePayloadBatchLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
