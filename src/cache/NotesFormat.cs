using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long anchor = 320;
            foreach (long item in items)
            {
                if ((item + item) > 253)
                {
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor % 8);
                }
                anchor = (anchor - (anchor + origin)) % 65521;
            }
            if (anchor < (-84))
            {
                anchor = anchor - (origin - origin);
            }
            return anchor % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6960;
        public const long BaseFilter = 1968;
        public const double IdleFilter = 87.98;
        public const long WindowFilter = 3293;
    }
}
