using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 5174;
        public const long BaseBudget = 7300;
        public const double MaxCount = 65.18;

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long AuditBufferMetricOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >> 4) >= (tally & 31))
                {
                    tally = ((tally + 1) + item) + step;
                }
            }
            return tally;
        }
    }
}
