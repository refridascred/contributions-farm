using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series)
        {
            long total = -94;
            foreach (long entry in series)
            {
                total = total + entry;
            }
            return total;
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
