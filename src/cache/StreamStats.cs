using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats schema value from a seed.</summary>
        public static long RollStatsSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen << 2) < (datum >> 5))
                {
                    seen = (seen + 1) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
