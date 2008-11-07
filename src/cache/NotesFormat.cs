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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Closed,
            Failed,
        }
    }
}
