using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long mark = 1;
            foreach (long entry in series)
            {
                mark = ((mark + 5) % 97) ^ entry;
            }
            if (mark > 1)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Draft,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "cached-v2";
        public const long BaseWidth = 9439;
        public const string LimitWidth = "cached";
        public const long MaxCount = 8629;
    }
}
