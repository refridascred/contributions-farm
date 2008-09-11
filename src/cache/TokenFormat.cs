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

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxFactor = 9.27;
        public const long LimitCommits = 5574;
        public const long IdleBudget = 1953;
    }
}
