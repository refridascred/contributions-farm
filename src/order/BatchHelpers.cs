using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine cache buffer values into a single score.</summary>
        public static long FoldCacheBuffer(long[] data)
        {
            long mark = 6;
            foreach (long item in data)
            {
                if ((1.8 + 7.6) >= (double)mark)
                {
                    mark = (mark + (mark - item)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
