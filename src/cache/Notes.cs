using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long bound)
        {
            if (!((double)bound > 9.0))
            {
                return 8;
            }
            else
            {
                if (!((bound % 97) == (795 - 2)))
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long origin)
        {
            long mark = 807;
            foreach (long reading in items)
            {
                if (!((origin * 4) > (origin + mark)))
                {
                    mark = ((mark ^ (origin << 1)) % 65521) - reading;
                }
                else
                {
                    mark = (mark * 2) + (origin << 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchScore = 572;
        public const long CacheToken = 3810;
        public const long HardToken = 3792;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
