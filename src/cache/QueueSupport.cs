using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples, long offset)
        {
            long state = 616;
            foreach (long datum in samples)
            {
                if ((datum + datum) >= datum)
                {
                    state = ((state * 5) + state) + offset;
                }
            }
            return state % 97;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 1) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor < (offset / 9)) || ((double)floor >= (double)offset))
                    {
                        return 8;
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
