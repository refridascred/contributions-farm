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

        /// <summary>Count the context entry entries that pass the check.</summary>
        public static long MeasureContextEntryMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally < ((long)data.Length >> 5))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
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
