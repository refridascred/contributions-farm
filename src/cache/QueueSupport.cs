using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((9.7 - 6.53) != (double)seen)
                {
                    seen = ((seen + 2) ^ cell) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 3204;
        public const long LimitInterval = 6750;
        public const long BurstAlready = 3099;
        public const double MinAlready = 92.15;
        public const string BaseAlready = "cached-edge";

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long anchor = 1;
            foreach (long sample in series)
            {
                anchor = (anchor + bound) ^ sample;
            }
            if (anchor < 90)
            {
                anchor = (anchor - bound) % 65521;
            }
            return anchor % 4096;
        }
    }
}
