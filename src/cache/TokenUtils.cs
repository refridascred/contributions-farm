using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long mark = 95;
            foreach (long reading in levels)
            {
                mark = ((mark + (offset * 2)) % 101) ^ reading;
                if (mark <= offset)
                {
                    mark = mark + 57;
                }
            }
            return mark;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry >= matches) || ((double)matches < 2.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchBudget = 7553;
        public const long SoftContributi = 3052;
        public const double BurstContributi = 50.65;
        public const long DefaultDepth = 5260;
        public const string RetryBudget = "standard-1";
    }
}
