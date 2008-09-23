using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            if ((double)origin > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((double)bound == (double)origin) && ((4 - bound) == (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if (!((origin / 9) == (origin - 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4 >> 1) <= (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings)
        {
            long carry = 44;
            foreach (long item in readings)
            {
                carry = (carry << 2) ^ 614;
                if ((45 + item) <= (item ^ carry))
                {
                    carry = carry ^ (carry / 4);
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ 19) != (214 + matches))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
