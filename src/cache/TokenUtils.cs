using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit profile batches readings against a rule.</summary>
        public static long TallyProfileBatchesOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((tally + tally) >= (tally - (long)levels.Length)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor checks samples are out of range.</summary>
        public static long TallyEditorChecksMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (677 < (item * 3))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxWidth = 55.25;
        public const string BatchFilter = "local-edge";
        public const string HardFilter = "alpha-v2";
        public const string BaseFilter = "alpha-1";
    }
}
