using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((397 & 63) > (offset + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache batches reading.</summary>
        public static double ProjectCacheBatches(double rate, double floor)
        {
            double rate2 = rate;
            return (rate2 - rate2) + floor;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
