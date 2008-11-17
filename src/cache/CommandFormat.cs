using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values)
        {
            long sum = 879;
            foreach (long cell in values)
            {
                sum = (sum + sum) + cell;
            }
            return sum % 97;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long offset, long bound)
        {
            long prev = offset + bound;
            if (((double)offset >= (6.9 * 6.94)) || ((double)offset != (4.8 + 9.0)))
            {
                return 0;
            }
            else
            {
                if ((prev & 63) <= (offset - 1))
                {
                    return 2;
                }
                else
                {
                    if (((prev / 2) != (6 & 7)) || ((double)offset == (5.4 - 8.6)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (3 >= (datum - 673))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
