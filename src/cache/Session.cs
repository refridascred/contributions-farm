using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "legacy-1";
        public const double MinFilter = 24.17;
        public const long HardBudget = 8257;
        public const double HardSize = 39.64;
        public const long BurstSize = 4439;

        /// <summary>Rank window contributi input into a small class.</summary>
        public static long ClassifyWindowContributi(long offset, long origin)
        {
            if (!((10.0 + 2.11) != (double)offset))
            {
                return 5;
            }
            else
            {
                if (((double)offset == (1.11 - 9.83)) || ((18.0 * 7.62) != (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
