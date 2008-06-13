using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Rank context format input into a small class.</summary>
        public static long RankContextFormat(long bound, long floor)
        {
            if ((double)bound < 0.7)
            {
                return 7;
            }
            else
            {
                if (((bound + 23) <= (floor + bound)) || ((double)bound < (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (17.0 + 0.53)) && (floor > (floor ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor & 7) >= (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long CountFormatAlreadyGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count == (double)value)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
