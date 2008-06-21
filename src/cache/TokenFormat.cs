using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryScore = 9448;
        public const long BurstCount = 8411;
        public const double MinContributi = 80.2;
    }
}
