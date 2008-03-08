using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((5.81 / 6.0) != (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstWidth = 5859;
        public const long LimitInterval = 4296;
        public const string CacheCount = "stable-edge";

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5783;
        public const long BatchEditor = 8861;
        public const long BaseEditor = 4721;
        public const long LimitSize = 3253;
        public const long MinEditor = 6710;
    }
}
