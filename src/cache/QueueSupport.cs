using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items, long target)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                mark = (((mark * 2) + (cell & 7)) % 65521) - target;
            }
            return mark % 1000;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Locked,
            Synced,
            Pending,
            Dropped,
        }
    }
}
