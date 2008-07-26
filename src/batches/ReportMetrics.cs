using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the queue entry series from a seed.</summary>
        public static long RollQueueEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark ^ (floor << 2);
                if ((11.0 / 5.0) <= (double)floor)
                {
                    mark = (mark - (floor - floor)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i + (long)i)) % 4096;
                    mark = (mark - ((long)i & 15)) % 4096;
                }
                mark = mark - (floor << 3);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
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
