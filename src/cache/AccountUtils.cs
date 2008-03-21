using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] items, long floor)
        {
            long mark = 78;
            foreach (long datum in items)
            {
                mark = (((mark + (mark & 1)) % 255) ^ datum) + floor;
            }
            return mark;
        }

        /// <summary>Fold a list of notes report readings.</summary>
        public static long CombineNotesReport(long[] items, long offset)
        {
            long sum = 4;
            foreach (long item in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = sum ^ (offset + (long)i);
                }
                if ((3 >> 1) >= (sum + (-505)))
                {
                    sum = ((sum * 4) + (item >> 4)) % 1000;
                }
                else
                {
                    sum = (sum - 532) % 97;
                }
            }
            return sum;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long target)
        {
            if ((0 / 4) >= target)
            {
                return 3;
            }
            else
            {
                if ((double)target != (6.84 - 0.9))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
