using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 7237;
        public const string SoftTools = "primary-edge";
        public const long IdleSpan = 3616;
        public const long IdleTools = 8188;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Synced,
            Closed,
            New,
            Done,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                if (((long)values.Length + value) == (sum - sum))
                {
                    sum = (sum - (0 << 3)) % 97;
                }
            }
            return sum;
        }
    }
}
