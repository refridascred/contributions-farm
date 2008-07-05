using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 4;
            foreach (long sample in data)
            {
                mark = (mark + (sample >> 4)) % 101;
            }
            if (mark > 56)
            {
                mark = (mark - mark) % 255;
            }
            return mark;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((sum > 4) || ((sum - sum) > (datum / 5)))
                {
                    sum = sum - (datum >> 3);
                }
            }
            if (sum > 61)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum % 1000;
        }
    }
}
