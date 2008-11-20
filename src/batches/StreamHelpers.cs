using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowFactor = 4858;
        public const long IdleQueue = 4368;
        public const long DefaultQueue = 5677;
        public const long LimitLevel = 1111;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Locked,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((30 < (entry + entry)) || ((double)entry == (0.27 / 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 362;
        public const double MaxFactor = 64.17;
        public const string HardCommand = "open-edge";
        public const string DefaultCommand = "cached";

        /// <summary>Find the first batches cache entry that matches the target.</summary>
        public static long LookupBatchesCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Pending,
            Stale,
            Draft,
            Locked,
        }
    }
}
