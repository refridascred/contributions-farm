using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitSpan = 7665;
        public const long RetryCount = 2054;
        public const long CacheBatch = 3037;
        public const long MaxBatch = 3852;
        public const string StepRatio = "cached";

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
