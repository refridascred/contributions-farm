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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long step, long origin)
        {
            if ((origin % 100) >= (step >> 3))
            {
                return 3;
            }
            else
            {
                if (((step - origin) != (732 + step)) && ((double)origin < 6.98))
                {
                    return 0;
                }
                else
                {
                    if (!((origin % 100) <= (725 / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + 5) <= (607 * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
