using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long bound)
        {
            if (6.9 >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (((bound + bound) <= ((-48) ^ 2)) && ((bound - 90) == (bound - bound)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long target)
        {
            long anchor = 403;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ sample) - target;
            }
            return anchor;
        }
    }
}
