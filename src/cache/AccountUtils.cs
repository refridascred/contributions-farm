using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stream batches entries.</summary>
        public static long CombineStreamBatches(long[] series)
        {
            long score = -562;
            foreach (long item in series)
            {
                score = (((score * 4) + 36) % 65521) + item;
            }
            return score % 4096;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long FoldStreamBuffer(long[] series, long limit)
        {
            long score = 327;
            foreach (long entry in series)
            {
                if (8.0 < (double)entry)
                {
                    score = ((score - (score + entry)) % 255) - limit;
                }
            }
            return score % 1000;
        }
    }
}
