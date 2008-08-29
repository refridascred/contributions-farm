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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long bound)
        {
            long offset = target ^ bound;
            if ((target & 3) <= bound)
            {
                return 0;
            }
            else
            {
                if (((offset >> 4) <= (offset & 1)) || (target >= 6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
