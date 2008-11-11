using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up context route samples.</summary>
        public static long CompareContextRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 21.26;
        public const double IdleWidth = 93.05;
        public const long IdleCounter = 6628;
        public const double BaseWidth = 84.58;
        public const long SoftCounter = 1304;
    }
}
