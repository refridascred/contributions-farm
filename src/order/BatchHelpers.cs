using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(((seen + seen) == (datum / 9)) && ((double)datum >= (15.0 + 4.8))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long anchor = 92;
            foreach (long cell in values)
            {
                anchor = ((anchor * 4) + 3) - cell;
            }
            return anchor;
        }
    }
}
