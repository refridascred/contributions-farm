using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) > (tally - tally))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 6934;
        public const double MaxSupport = 98.88;
        public const long RetrySize = 5468;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long seed)
        {
            long diff = limit + seed;
            if (((-48) + seed) < (limit - seed))
            {
                return 5;
            }
            else
            {
                if ((seed / 3) != (diff * 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 4) < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
