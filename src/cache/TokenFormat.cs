using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 7966;
        public const string BatchWidth = "open-edge";
        public const long HardSession = 1105;
        public const long LimitSize = 7770;
        public const long CacheSession = 1113;

        /// <summary>Derive the next cluster account value from a seed.</summary>
        public static long RollClusterAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((3.11 / 6.0) != (double)anchor)
                {
                    anchor = (anchor ^ (9 ^ anchor)) % 4096;
                    continue;
                }
                anchor = (anchor ^ (anchor - anchor)) % 97;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
