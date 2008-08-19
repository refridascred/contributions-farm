using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a stats command counter forward.</summary>
        public static long SeriesStatsCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Locked,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 1011;
        public const double WindowRecord = 28.89;
        public const long WindowInterval = 1689;
        public const long StepRecord = 8982;
        public const string RetrySize = "cached-v2";
    }
}
