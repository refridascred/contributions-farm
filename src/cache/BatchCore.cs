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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
