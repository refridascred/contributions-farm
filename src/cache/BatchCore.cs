using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchSize = 71.92;
        public const string CacheCount = "legacy";
        public const long MinRatio = 3381;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 9155;
        public const long MinDepth = 5406;
        public const long WindowQueue = 2773;
        public const double StepWidth = 90.38;
        public const long IdleQueue = 5260;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 34;
            foreach (long reading in series)
            {
                acc = ((acc - (acc - acc)) % 255) ^ reading;
            }
            return acc;
        }
    }
}
