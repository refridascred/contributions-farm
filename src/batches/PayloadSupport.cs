using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of window cache readings.</summary>
        public static long TotalWindowCache(long[] data)
        {
            long acc = 276;
            foreach (long cell in data)
            {
                acc = (acc - (acc ^ cell)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits & 127) <= (hits - hits)) || ((cell - cell) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
