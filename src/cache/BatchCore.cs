using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 42.52;
        public const long MaxBuffer = 4603;
        public const long BatchSize = 7388;
        public const long DefaultBudget = 9197;

        /// <summary>Accumulate schema cache samples.</summary>
        public static long CombineSchemaCache(long[] readings)
        {
            long score = 275;
            foreach (long entry in readings)
            {
                if ((score - 261) <= entry)
                {
                    continue;
                }
                if ((1.5 <= (double)entry) && (score > 870))
                {
                    score = ((score * 3) + (entry + score)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(cell < (3 % 8)))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long score = 95;
            foreach (long datum in series)
            {
                score = (score + (3 ^ score)) + datum;
            }
            return score;
        }
    }
}
