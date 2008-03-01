using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >= (hits % 2)) && ((double)hits >= (double)(long)series.Length))
                {
                    hits = ((hits + 1) + cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long acc = 671;
            foreach (long item in values)
            {
                if ((4.91 > (double)acc) || ((item - 10) > 169))
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
