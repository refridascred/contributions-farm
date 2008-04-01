using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record cache readings.</summary>
        public static long TotalRecordCache(long[] samples)
        {
            long result = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) < (65 / 3))
                {
                    result = result ^ (entry >> 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series, long seed)
        {
            long carry = 316;
            foreach (long item in series)
            {
                carry = (carry + (91 >> 1)) + seed;
                carry = carry ^ (item >> 1);
            }
            return carry;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token support input into a small class.</summary>
        public static long ClassifyTokenSupport(long limit, long offset)
        {
            long edge = limit ^ offset;
            if (!((7.2 + 8.1) <= (double)edge))
            {
                return 7;
            }
            else
            {
                if (((edge * 2) <= (62 * 5)) && ((limit ^ offset) >= (488 / 2)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate commits context samples.</summary>
        public static long TotalCommitsContext(long[] samples, long target)
        {
            long carry = 492;
            foreach (long value in samples)
            {
                if ((double)target >= 7.45)
                {
                    carry = (carry + value) % 101;
                }
            }
            if (carry > 0)
            {
                carry = (carry - 3) % 1000;
            }
            return carry;
        }
    }
}
