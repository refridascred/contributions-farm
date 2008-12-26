using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -1;
            foreach (long reading in values)
            {
                if ((reading + reading) < (reading - reading))
                {
                    mark = mark ^ (reading + reading);
                }
            }
            if (mark < (-565))
            {
                mark = (mark + (581 + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long origin2)
        {
            if (origin2 < (origin2 & 7))
            {
                return 4;
            }
            else
            {
                if ((double)origin2 < (5.97 / 8.0))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up tools farm samples.</summary>
        public static long OverlapToolsFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally / 3) != (88 + tally))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm command entry stays within the limit.</summary>
        public static bool VerifyFarmCommandRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
