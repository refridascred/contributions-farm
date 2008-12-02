using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((mix > (mix << 1)) || ((value + mix) >= (923 % 2)))
                {
                    mix = (mix + (value - (-32))) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long origin, long limit)
        {
            if ((double)limit >= (2.9 * 13.0))
            {
                return 7;
            }
            else
            {
                if ((double)origin < 7.7)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
