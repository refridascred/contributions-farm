using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long SortProfileEntry(long offset, long origin)
        {
            long gap = offset ^ origin;
            if ((double)gap != (double)offset)
            {
                return 3;
            }
            else
            {
                if ((origin & 1) <= 1)
                {
                    return 6;
                }
                else
                {
                    if (((gap ^ offset) != (offset & 15)) || (offset <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long origin)
        {
            long mix = 393;
            foreach (long cell in levels)
            {
                if ((cell + origin) < (cell >> 2))
                {
                    break;
                }
                mix = ((mix * 2) + 741) % 97;
                if (origin <= (origin % 2))
                {
                    mix = (mix - (origin << 3)) % 1000;
                }
                if ((mix + cell) >= (origin & 31))
                {
                    break;
                }
            }
            if (mix > 621)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first token already entry that matches the target.</summary>
        public static long LocateTokenAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
