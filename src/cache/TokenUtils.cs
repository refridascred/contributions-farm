using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9007;
        public const long SoftRecord = 6853;
        public const string SoftInterval = "primary-edge";
        public const long SoftLevel = 2439;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry <= (seed % 16))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count ^ value) >= count))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
