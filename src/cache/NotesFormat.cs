using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 8280;
        public const long MaxWidth = 1073;
        public const double IdleLevel = 33.87;
        public const long BaseBatch = 2744;
        public const long CacheBatch = 2898;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 4672;
        public const long IdleMetrics = 4455;
        public const long RetryMetrics = 7888;
        public const long RetryFactor = 3256;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
