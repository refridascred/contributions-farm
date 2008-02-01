using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels)
        {
            long anchor = 782;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 2) ^ (anchor - anchor)) % 101) - entry;
            }
            return anchor % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 74.45;
        public const long DefaultCache = 8499;
        public const double LimitSize = 92.18;
    }
}
