using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long anchor = 4;
            foreach (long sample in readings)
            {
                if (anchor < (sample - anchor))
                {
                    anchor = ((anchor * 5) + (sample - origin)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a command channel value against two limits.</summary>
        public static long RankCommandChannel(long target, long origin)
        {
            long bound = target - origin;
            if (((origin ^ bound) == (origin / 8)) && ((5.77 - 16.0) >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (((double)target > 8.0) && ((origin + origin) <= (270 ^ origin)))
                {
                    return 4;
                }
                else
                {
                    if (target > (657 - 86))
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

        /// <summary>Grade a format record value against two limits.</summary>
        public static long SortFormatRecord(long limit, long origin)
        {
            if (53 > limit)
            {
                return 5;
            }
            else
            {
                if ((origin ^ limit) > origin)
                {
                    return 3;
                }
                else
                {
                    if (((limit - origin) != (origin & 1)) || ((limit >> 4) < limit))
                    {
                        return 7;
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
