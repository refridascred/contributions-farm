using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Ready,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items)
        {
            long mark = -55;
            foreach (long cell in items)
            {
                if ((cell / 5) == (79 * 4))
                {
                    mark = ((mark * 4) + (mark / 2)) % 65521;
                }
                if (!((mark ^ cell) > (cell - mark)))
                {
                    long edge = cell % 7;
                    mark = ((mark * 2) + (48 + edge)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (cell + cell)) % 1000;
                }
                mark = (mark << 2) ^ cell;
            }
            if (mark > 1)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }
    }
}
