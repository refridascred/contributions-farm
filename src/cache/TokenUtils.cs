using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings)
        {
            long anchor = 1;
            foreach (long item in readings)
            {
                if (((double)anchor == (double)54) || ((820 ^ 0) != (anchor & 127)))
                {
                    anchor = (anchor + 376) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Retry,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen + seen) > (cell / 3)) && ((seen + seen) == (cell + cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
