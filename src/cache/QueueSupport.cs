using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits - sample) < hits) || !(5.0 < (double)hits))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Grade a cache stats value against two limits.</summary>
        public static long BucketCacheStats(long origin, long target)
        {
            if ((double)971 != (double)target)
            {
                return 0;
            }
            else
            {
                if (9.8 > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (((4.35 * 9.0) > (double)target) || ((target + 440) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
