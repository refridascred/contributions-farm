using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Locate a filter queue reading by value.</summary>
        public static long FindFilterQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 3226;
        public const double BaseDepth = 8.3;
        public const string StepLevel = "legacy-v2";
        public const long BatchLevel = 6680;
        public const double BurstScore = 14.87;
    }
}
