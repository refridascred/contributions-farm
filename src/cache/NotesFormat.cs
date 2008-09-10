using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long offset, long seed)
        {
            if (seed < (offset + offset))
            {
                return 5;
            }
            else
            {
                if (offset <= (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (((3.0 + 7.0) == (double)offset) && ((offset + offset) < (offset >> 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every checks report entry stays within the limit.</summary>
        public static bool CheckChecksReportBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
