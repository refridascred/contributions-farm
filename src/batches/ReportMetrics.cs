using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long SeriesQueueFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)score == (5.0 * 1.9))
                {
                    score = score + score;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit command already readings against a rule.</summary>
        public static long CountCommandAlreadyHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading << 3) > ((-982) / 8))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 4496;
        public const long StepDepth = 8679;
        public const long DefaultBatches = 4247;
        public const double BatchScore = 52.4;
    }
}
