using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "alpha-v2";
        public const long WindowFactor = 7481;
        public const long StepAccount = 822;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (6.9 / 8.0))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batches account readings against a rule.</summary>
        public static long AuditBatchesAccountGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((10.0 / 8.0) == (double)matches) && ((entry + entry) <= (848 - matches)))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
