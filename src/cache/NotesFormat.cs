using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of checks route entries.</summary>
        public static long TotalChecksRoute(long[] data, long origin)
        {
            long anchor = 433;
            foreach (long cell in data)
            {
                anchor = ((anchor - origin) % 65521) + cell;
                if (((anchor - anchor) < (origin ^ anchor)) && ((anchor + (long)data.Length) != (57 % 8)))
                {
                    anchor = (anchor * 4) + (78 % 64);
                }
                else
                {
                    anchor = (anchor - 92) % 97;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor + (anchor * 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long step)
        {
            long delta = offset ^ step;
            if (((offset ^ step) >= offset) || ((double)delta != (double)step))
            {
                return 1;
            }
            else
            {
                if ((double)5 != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset / 6) >= (delta - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (1.1 >= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples)
        {
            long carry = -410;
            foreach (long item in samples)
            {
                if (0.7 > (double)carry)
                {
                    carry = (carry + carry) % 97;
                    continue;
                }
                if (item > (102 + carry))
                {
                    carry = ((carry * 5) + (carry - item)) % 65521;
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (carry & 127)) % 97;
            }
            return carry % 4096;
        }
    }
}
