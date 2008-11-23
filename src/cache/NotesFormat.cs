using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Locked,
            New,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long floor)
        {
            long mark = 8;
            foreach (long datum in series)
            {
                if ((datum + floor) <= floor)
                {
                    mark = ((mark * 4) + (datum >> 2)) % 65521;
                }
                if ((double)datum > (3.3 + 4.58))
                {
                    mark = mark ^ datum;
                }
                mark = (mark << 2) ^ (mark % 100);
            }
            if (mark > 182)
            {
                mark = (mark - (floor + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
