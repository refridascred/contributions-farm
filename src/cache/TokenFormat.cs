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

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long anchor = -648;
            foreach (long sample in readings)
            {
                if ((origin - 83) > anchor)
                {
                    anchor = (((anchor * 4) + anchor) % 97) ^ sample;
                }
                anchor = (anchor - anchor) % 101;
            }
            if (anchor > 45)
            {
                anchor = ((anchor << 2) ^ (origin - origin)) % 97;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5783;
        public const long BatchEditor = 8861;
        public const long BaseEditor = 4721;
        public const long LimitSize = 3253;
        public const long MinEditor = 6710;
    }
}
