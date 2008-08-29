using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stats filter readings.</summary>
        public static long TotalStatsFilter(long[] levels, long target)
        {
            long score = 333;
            foreach (long cell in levels)
            {
                if ((score > (score & 63)) && (score < (score ^ cell)))
                {
                    continue;
                }
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 3) ^ target) % 97) - (long)i;
                }
                score = score - (score + score);
            }
            return score % 1000;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long anchor = 68;
            foreach (long value in series)
            {
                anchor = (((anchor << 2) ^ (anchor / 4)) ^ value) - offset;
            }
            return anchor % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i * 2) == (mark + mark)) || ((mark << 1) == ((long)i * 3)))
                {
                    mark = (mark * 2) + 23;
                }
                mark = (mark - 9) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
