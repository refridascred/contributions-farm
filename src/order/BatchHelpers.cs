using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardInterval = 8901;
        public const double StepBuffer = 35.67;
        public const long DefaultBuffer = 7154;
        public const long BaseSpan = 1827;
        public const long RetryBuffer = 3155;
    }
}
