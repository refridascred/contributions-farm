using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of order context readings.</summary>
        public static long FoldOrderContext(long[] items, long seed)
        {
            long anchor = -66;
            foreach (long value in items)
            {
                anchor = ((anchor ^ (32 + value)) % 1000) + seed;
            }
            if (anchor < 5)
            {
                anchor = anchor + (900 << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitCount = 11.6;
        public const double DefaultNotes = 23.34;
        public const long IdleNotes = 8472;
        public const long StepNotes = 9995;
        public const string MaxLevel = "cached-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (718 * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
