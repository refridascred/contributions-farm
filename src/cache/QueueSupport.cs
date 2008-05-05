using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 103;
            foreach (long item in data)
            {
                if ((carry ^ carry) <= (carry - item))
                {
                    carry = carry ^ (item / 4);
                }
            }
            if (carry < 694)
            {
                carry = ((carry << 3) ^ ((-73) * 2)) % 255;
            }
            return carry;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                if ((entry >> 4) == (anchor - 11))
                {
                    anchor = (anchor * 2) + (924 >> 2);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 4096;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Rank batch tools input into a small class.</summary>
        public static long GradeBatchTools(long step, long origin)
        {
            if ((origin / 3) <= origin)
            {
                return 3;
            }
            else
            {
                if ((8.0 * 13.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((origin << 1) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
