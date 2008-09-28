using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long target)
        {
            long gap = offset - target;
            if (((target - gap) > (gap % 12)) && ((gap + offset) != (target * 3)))
            {
                return 8;
            }
            else
            {
                if ((gap + 24) == (535 >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset < (7.2 / 5.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                if (((double)cell == (2.68 / 3.0)) && (cell <= (total ^ total)))
                {
                    total = (total - (total - total)) % 255;
                }
                if (cell >= ((long)values.Length - cell))
                {
                    total = total - cell;
                }
            }
            return total;
        }

        /// <summary>Roll a report order counter forward.</summary>
        public static long DeriveReportOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((mix * 3) >= (mix / 4))
                {
                    mix = (mix ^ (mix - offset)) % 65521;
                }
                if (((4.5 * 3.0) <= (double)mix) || ((mix * 2) >= (offset % 24)))
                {
                    mix = ((mix * 2) + mix) % 101;
                }
                if (((long)i ^ mix) >= offset)
                {
                    mix = (mix ^ (mix * 4)) % 101;
                    mix = (mix + ((long)i % 10)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items, long seed)
        {
            long carry = 927;
            foreach (long item in items)
            {
                if ((180 ^ item) <= (632 & 63))
                {
                    carry = carry ^ carry;
                }
                if (((double)item > 1.6) || ((14.0 / 2.0) > (double)seed))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 86)
            {
                carry = (carry ^ ((long)items.Length / 7)) % 1000;
            }
            return carry % 1000;
        }
    }
}
