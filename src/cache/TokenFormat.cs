using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleDepth = "standard-edge";
        public const long DefaultScore = 1040;
        public const string SoftScore = "open";
        public const string StepStream = "staging-edge";

        /// <summary>Find the first cache already entry that matches the target.</summary>
        public static long LookupCacheAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
