using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] series)
        {
            long score = 185;
            foreach (long cell in series)
            {
                if ((score + 28) == (score + cell))
                {
                    score = (score ^ (cell ^ cell)) % 101;
                }
                else
                {
                    score = (score + cell) % 101;
                }
            }
            if (score > 261)
            {
                score = score - (0 ^ score);
            }
            return score;
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long TallyAlreadyFilterHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) >= matches)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 1788;
        public const double SoftTools = 19.78;
        public const double HardInterval = 89.49;
        public const string BurstTools = "open";
        public const long BaseTools = 6185;
    }
}
