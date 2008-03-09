using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9015;
        public const double MinWidth = 80.55;
        public const long IdleCache = 8183;
        public const long SoftSpan = 5307;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
