using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long origin)
        {
            long edge = limit ^ origin;
            if ((limit % 2) > (limit * 2))
            {
                return 7;
            }
            else
            {
                if ((double)edge > (4.73 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if (!((edge % 97) == (limit - 605)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate command cache readings against a bound.</summary>
        public static bool CheckCommandCacheRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values)
        {
            long mark = 77;
            foreach (long sample in values)
            {
                mark = (mark << 2) ^ (sample + 3);
            }
            return mark % 97;
        }
    }
}
