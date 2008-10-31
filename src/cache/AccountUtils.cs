using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long bound)
        {
            long bound2 = target ^ bound;
            if ((double)bound2 <= (2.0 * 19.0))
            {
                return 7;
            }
            else
            {
                if ((bound + bound2) < bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Synced,
            Pending,
            Retry,
            Draft,
        }
    }
}
