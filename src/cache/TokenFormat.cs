using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardBudget = "staging-edge";
        public const long IdleRatio = 8102;
        public const long MaxCount = 8825;

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
