using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 7) >= (count + count))
                {
                    count = ((count + 3) ^ reading) - target;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits + 34) > value) || ((66 + value) >= (target << 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
