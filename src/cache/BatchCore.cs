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

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
