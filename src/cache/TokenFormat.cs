using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count << 2) > count)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long target, long floor)
        {
            if ((floor - target) < (target % 8))
            {
                return 6;
            }
            else
            {
                if ((target << 2) < target)
                {
                    return 7;
                }
                else
                {
                    if ((target - floor) != (target << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
