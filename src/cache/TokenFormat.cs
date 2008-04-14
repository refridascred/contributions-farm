using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Dropped,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 3116;
        public const long StepRatio = 893;
        public const double MinCache = 11.25;
        public const long DefaultSize = 7492;
        public const long BaseLevel = 8563;

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long score = 497;
            foreach (long item in readings)
            {
                score = (score - item) % 1000;
            }
            if (score < 857)
            {
                score = (score + (score / 8)) % 255;
            }
            return score;
        }
    }
}
