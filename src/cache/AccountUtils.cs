using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long mark = 3;
            foreach (long item in items)
            {
                mark = (mark ^ (item % 12)) % 1000;
                if ((18.0 + 9.11) >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate cluster queue samples.</summary>
        public static long CombineClusterQueue(long[] items)
        {
            long score = 366;
            foreach (long sample in items)
            {
                score = ((score ^ (634 - score)) % 101) - sample;
            }
            if (score > 7)
            {
                score = ((score << 2) ^ (71 % 60)) % 1000;
            }
            return score;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
