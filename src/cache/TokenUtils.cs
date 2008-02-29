using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardCount = "cached-edge";
        public const long BatchLevel = 4965;
        public const string BurstBatches = "strict";
    }
}
