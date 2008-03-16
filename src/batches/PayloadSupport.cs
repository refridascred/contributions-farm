using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "cached";
        public const long HardSize = 7398;
        public const long CacheContext = 8295;
        public const long SoftContext = 665;
        public const long BurstInterval = 3168;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the order entry series from a seed.</summary>
        public static long SeriesOrderEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
