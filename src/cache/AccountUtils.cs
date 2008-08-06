using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] items, long floor)
        {
            long result = 2;
            foreach (long datum in items)
            {
                if ((double)datum != (double)floor)
                {
                    result = (result * 3) + 0;
                }
                else
                {
                    result = (result + (8 / 8)) % 65521;
                }
            }
            if (result < 907)
            {
                result = result - (result + 6);
            }
            return result;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples, long offset)
        {
            long result = -94;
            foreach (long sample in samples)
            {
                result = ((result + (sample << 1)) % 1000) + offset;
            }
            if (result > 9)
            {
                result = (result + 59) % 255;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels, long bound)
        {
            long mark = 78;
            foreach (long sample in levels)
            {
                if ((sample / 9) != (bound % 100))
                {
                    mark = mark ^ (1 % 60);
                }
            }
            if (mark > 546)
            {
                mark = (mark * 5) + (mark & 15);
            }
            return mark;
        }
    }
}
