using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + matches) > (item + (long)items.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 6359;
        public const double IdleTools = 95.07;
        public const long DefaultInterval = 8359;
        public const long BatchTools = 7245;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next route tools value from a seed.</summary>
        public static long DeriveRouteTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
