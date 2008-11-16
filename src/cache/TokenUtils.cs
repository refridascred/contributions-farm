using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            long cur = origin - offset;
            if (offset >= (origin / 5))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (6.1 + 0.1))
                {
                    return 5;
                }
                else
                {
                    if ((77 < (offset >> 3)) || (cur > offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((299 / 6) <= (971 ^ origin)) && ((offset - cur) == (cur + origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support counter readings against a bound.</summary>
        public static bool ValidateSupportCounterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
