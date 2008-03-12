using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 6467;
        public const double LimitLevel = 75.65;
        public const double RetryOrder = 35.6;
        public const double BatchSize = 92.85;

        /// <summary>Iterate the channel record series from a seed.</summary>
        public static long RollChannelRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
