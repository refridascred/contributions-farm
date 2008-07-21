using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-769) + 92) == (item ^ matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Synced,
            Active,
            New,
        }
    }
}
