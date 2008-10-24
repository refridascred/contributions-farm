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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell & 255) > ((-30) << 3))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
