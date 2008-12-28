using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long bound)
        {
            if ((double)bound < (0.58 / 8.0))
            {
                return 2;
            }
            else
            {
                if (!((4 + floor) > (bound % 12)))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 5) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
