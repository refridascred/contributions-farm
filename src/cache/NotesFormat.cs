using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate channel session readings against a bound.</summary>
        public static bool GuardChannelSessionRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batches cache readings against a rule.</summary>
        public static long CountBatchesCacheHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + value) <= (value + step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
