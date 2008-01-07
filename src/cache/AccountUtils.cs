using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.0 + 7.13) != (double)seed)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.17;
        public const double MaxWidth = 3.12;
        public const string WindowCommits = "latest-edge";
        public const double BurstCommits = 79.93;
        public const long CacheWidth = 2533;

        /// <summary>Measure how many channel batch samples are out of range.</summary>
        public static long TallyChannelBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + item) != (6 ^ 24))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
