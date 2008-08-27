using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > (639 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3510;
        public const long CacheDepth = 6755;
        public const long CacheNotes = 1437;
    }
}
