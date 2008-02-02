using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxWidth = 1229;
        public const string DefaultStats = "open-v2";
        public const long CacheStats = 6505;
        public const string BatchStats = "local";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Retry,
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Stale,
            Failed,
        }
    }
}
