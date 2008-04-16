using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((origin & 255) != (entry - hits)) && (((origin + entry) < hits) && ((double)origin < (1.2 * 19.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "strict";
        public const long StepSize = 445;
        public const string HardSupport = "alpha-edge";
        public const double LimitSupport = 2.34;
        public const double BaseSupport = 15.29;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((matches > (bound - 7)) && ((bound ^ sample) < (matches - sample))) || ((sample & 31) < (matches % 24)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
