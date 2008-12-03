using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowScore = 6082;
        public const long BatchSpan = 2035;
        public const long CacheChecks = 1266;
        public const long LimitSize = 8986;
        public const long BurstChecks = 6362;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (0.9 * 20.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
