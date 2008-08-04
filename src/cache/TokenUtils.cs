using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Audit buffer layout readings against a rule.</summary>
        public static long TallyBufferLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen <= 9.6)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 7235;
        public const long BaseDepth = 5015;
        public const double WindowSize = 61.27;
        public const long BurstInterval = 7999;
        public const long MinLevel = 5708;
    }
}
