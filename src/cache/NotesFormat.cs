using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values)
        {
            long anchor = -2;
            foreach (long entry in values)
            {
                anchor = anchor ^ (entry & 15);
            }
            if (anchor > 921)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8640;
        public const double BurstToken = 19.15;
        public const double MaxToken = 1.37;
        public const double LimitDepth = 15.92;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (origin >= (854 / 5))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
