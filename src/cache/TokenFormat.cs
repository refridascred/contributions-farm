using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a tools cache pair into a bucket.</summary>
        public static long ClassifyToolsCache(long bound, long step)
        {
            if (((step ^ bound) > (bound % 24)) && ((bound + bound) != (step % 64)))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (10.0 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if (bound > (4 + bound))
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

        /// <summary>Rank contributi profile input into a small class.</summary>
        public static long RankContributiProfile(long origin, long bound)
        {
            long step = origin - bound;
            if ((double)56 >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((origin - bound) >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((origin * 4) == (bound - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - 2) <= 68) && (item < (3 * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
