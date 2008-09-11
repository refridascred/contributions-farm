using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit queue editor readings against a rule.</summary>
        public static long CountQueueEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)hits > 1.07) && ((datum * 4) != (datum + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((97 + reading) >= reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstFactor = 7935;
        public const double BaseBatches = 23.14;
        public const long MinDepth = 3949;
        public const double WindowRatio = 84.12;
        public const long RetryBatches = 8544;
    }
}
