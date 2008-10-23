using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits < 2.3) || ((hits & 15) != (hits + hits)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "strict";
        public const long HardQueue = 1574;
        public const long MaxLevel = 3028;
        public const string CacheRatio = "staging-1";
        public const long DefaultInterval = 5682;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Done,
        }
    }
}
