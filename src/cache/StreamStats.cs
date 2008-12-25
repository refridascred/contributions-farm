using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix ^ (mix + limit)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Look up the position of a context metric sample.</summary>
        public static long LookupContextMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
