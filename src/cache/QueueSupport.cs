using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a schema filter reading by value.</summary>
        public static long LocateSchemaFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 2923;
        public const double MaxSpan = 24.9;
        public const double BurstChannel = 89.66;
        public const long CacheChannel = 8797;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
