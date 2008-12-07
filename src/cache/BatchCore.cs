using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Stale,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count - value) >= (value - (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes session readings.</summary>
        public static long ScoreNotesSession(long[] items)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if ((5.0 + 5.6) > (double)(long)items.Length)
                {
                    mark = mark ^ (reading - reading);
                }
            }
            if (mark < 89)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Check that every cache editor entry stays within the limit.</summary>
        public static bool CheckCacheEditorLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
