using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Failed,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 4508;
        public const long StepTools = 6292;
        public const long BurstRatio = 531;
    }
}
