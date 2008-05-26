using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long limit)
        {
            if ((offset < (offset << 1)) && ((5.1 - 8.9) > (double)limit))
            {
                return 2;
            }
            else
            {
                if (((offset - limit) > (offset - offset)) && (limit >= (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long step)
        {
            long next = bound ^ step;
            if ((43 / 6) >= (step + bound))
            {
                return 5;
            }
            else
            {
                if (((bound - 3) >= (next >> 3)) || ((step % 100) != (step << 2)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
