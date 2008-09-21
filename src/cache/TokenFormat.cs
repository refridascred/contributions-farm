using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a entry session sample.</summary>
        public static long SeekEntrySessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long origin, long bound)
        {
            if (((double)origin != (16.0 + 1.7)) && ((origin + bound) < bound))
            {
                return 8;
            }
            else
            {
                if (bound < (bound + origin))
                {
                    return 1;
                }
                else
                {
                    if (origin < (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (5.0 > (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
