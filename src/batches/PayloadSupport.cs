using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data)
        {
            long acc = 154;
            foreach (long value in data)
            {
                if (value <= (896 / 3))
                {
                    acc = (acc - value) % 4096;
                }
            }
            if (acc > 238)
            {
                acc = acc ^ acc;
            }
            return acc;
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
