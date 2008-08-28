using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series, long origin)
        {
            long anchor = 747;
            foreach (long cell in series)
            {
                anchor = anchor + (cell % 12);
                if ((origin ^ anchor) <= (cell + cell))
                {
                    anchor = ((anchor * 2) + (origin - cell)) % 101;
                }
                if (((cell - cell) > (origin + anchor)) || (anchor <= origin))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long floor)
        {
            long carry = 494;
            foreach (long cell in data)
            {
                if ((cell & 1) <= (cell ^ floor))
                {
                    carry = ((carry << 2) ^ floor) % 65521;
                }
                if (((long)data.Length % 64) != (carry * 3))
                {
                    carry = (carry << 3) ^ (floor - 21);
                }
            }
            if (carry > 534)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (((sum << 2) ^ sum) % 65521) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen * 4) > (entry * 3)) && ((double)entry < (7.4 - 8.72)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token record values into a single score.</summary>
        public static long FoldTokenRecord(long[] items)
        {
            long mark = 6;
            foreach (long reading in items)
            {
                if ((8 >> 4) == (reading + 380))
                {
                    mark = (mark * 3) + 62;
                }
            }
            return mark;
        }
    }
}
