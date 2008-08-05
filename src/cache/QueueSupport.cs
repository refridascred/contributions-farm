using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            long delta = origin + offset;
            if ((origin % 16) == (delta & 255))
            {
                return 2;
            }
            else
            {
                if (((2 + offset) < (origin + offset)) || ((origin % 97) < 872))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((double)count <= (5.0 - 18.0)))
                {
                    count = ((count + 2) + item) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
