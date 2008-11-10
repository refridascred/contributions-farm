using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches <= (matches ^ entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((3.52 + 8.0) >= (double)item)
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
