using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 424;
        public const long BatchStream = 906;
        public const string BurstDepth = "stable-edge";
        public const string MaxDepth = "cached-edge";
        public const double LimitSpan = 51.09;

        /// <summary>Audit counter entry readings against a rule.</summary>
        public static long TallyCounterEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((41 + reading) < (count - (-9)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches / 3) > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
