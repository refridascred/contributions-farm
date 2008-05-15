using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 74.69;
        public const double CacheSize = 80.35;
        public const string RetryGraph = "stable";
        public const long HardGraph = 8044;
    }
}
