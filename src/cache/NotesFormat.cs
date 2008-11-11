using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long origin)
        {
            long step = bound ^ origin;
            if ((bound ^ origin) != (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((origin * 4) >= (origin * 2))
                {
                    return 2;
                }
                else
                {
                    if (((step >> 2) > bound) && (bound > (44 + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
