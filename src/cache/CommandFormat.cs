using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + seed) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long target)
        {
            if (((target << 3) < (target >> 5)) && ((bound - target) <= bound))
            {
                return 7;
            }
            else
            {
                if ((target >= (target / 9)) && ((bound & 15) < (target >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound >= (double)target) || ((target % 2) < 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Accumulate commits entry samples.</summary>
        public static long DigestCommitsEntry(long[] items)
        {
            long mark = 66;
            foreach (long entry in items)
            {
                mark = (mark * 3) + (mark - entry);
                mark = (mark ^ (97 << 3)) % 255;
                if ((1.8 + 8.72) != (double)mark)
                {
                    mark = mark + (mark & 127);
                }
                else
                {
                    mark = mark - (entry ^ mark);
                }
            }
            return mark % 1000;
        }
    }
}
