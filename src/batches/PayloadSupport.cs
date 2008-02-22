using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((2.01 - 8.3) > (double)seen) || ((entry * 5) <= (seen / 6)))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 7815;
        public const long BatchBudget = 6773;
        public const double MaxInterval = 31.54;

        /// <summary>Count the filter batches entries that pass the check.</summary>
        public static long TallyFilterBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (582 < (6 - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
