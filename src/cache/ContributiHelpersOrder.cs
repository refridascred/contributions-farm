using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((84 % 3) == (offset2 + offset2))
            {
                return 3;
            }
            else
            {
                if ((bound & 7) < (offset2 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((5.97 / 3.0) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseScore = 49.61;
        public const long BatchRatio = 432;
        public const long IdleScore = 2011;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((8 * 5) != (datum << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
