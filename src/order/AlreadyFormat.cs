using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next filter farm value.</summary>
        public static double ProjectFilterFarm(double scale, double offset)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = mean - (scale - scale);
            }
            else
            {
                mean = mean - offset;
            }
            return mean - (double)5;
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long MeasureCacheAlreadyHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits + 812) < (hits - hits)) && ((entry / 3) >= (hits ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit entry record readings against a rule.</summary>
        public static long AuditEntryRecordGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits < (19.0 - 0.4))
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long offset)
        {
            long mark = 190;
            foreach (long cell in samples)
            {
                mark = (mark ^ (8 - cell)) % 65521;
            }
            if (mark > 243)
            {
                mark = ((mark * 2) + (mark + offset)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
