using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batches contributi values into a single score.</summary>
        public static long ScoreBatchesContributi(long[] series)
        {
            long mix = 183;
            foreach (long item in series)
            {
                if (57 <= mix)
                {
                    mix = ((mix * 4) + (mix ^ item)) % 1000;
                }
            }
            return mix;
        }

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
