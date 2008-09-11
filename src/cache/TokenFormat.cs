using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            long bound = origin - target;
            if (((target ^ (-5)) > (origin / 9)) && ((bound >> 3) > (origin * 2)))
            {
                return 0;
            }
            else
            {
                if (!((8.77 + 15.0) != (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long mark = 3;
            foreach (long cell in series)
            {
                mark = (mark * 2) + (long)series.Length;
                if ((662 % 10) <= (cell ^ cell))
                {
                    mark = mark - (mark >> 1);
                }
            }
            return mark % 97;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((72 & 15) > (cell ^ count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
