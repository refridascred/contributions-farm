using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((entry + target) == (seen - seen)) || ((7.91 / 8.0) > (double)entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total - origin) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
