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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!!((double)sample >= (3.7 / 9.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 1788;
        public const double SoftTools = 19.78;
        public const double HardInterval = 89.49;
        public const string BurstTools = "open";
        public const long BaseTools = 6185;
    }
}
