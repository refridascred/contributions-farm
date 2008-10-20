using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count * 3) > (step ^ 37)) || !((7.0 - 0.79) >= (double)step))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 418;
        public const long BurstCount = 5848;
        public const long HardSize = 447;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long origin)
        {
            if ((seed ^ origin) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if ((double)origin != (6.3 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed == (3.3 - 15.0)) || ((seed & 3) == (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-9) / 8) > (seed / 7))
                        {
                            return 5;
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
}
