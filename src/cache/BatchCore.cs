using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BaseWidth = 34.82;
        public const long MaxAlready = 3693;
        public const long StepAlready = 1991;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Retry,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Match up buffer order samples.</summary>
        public static long OverlapBufferOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
