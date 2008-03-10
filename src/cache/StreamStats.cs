using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Dropped,
            New,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] readings, long limit)
        {
            long anchor = 64;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ limit) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)entry == (14.0 / 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
