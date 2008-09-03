using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 2;
            foreach (long item in readings)
            {
                if (!((item + anchor) > (367 << 2)))
                {
                    anchor = (anchor + (item << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (item + item)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long floor)
        {
            if ((double)782 == (double)offset)
            {
                return 5;
            }
            else
            {
                if (!((double)floor != (1.32 + 10.0)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + (long)items.Length) <= matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
