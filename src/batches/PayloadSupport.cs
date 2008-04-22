using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long bound)
        {
            long acc = 27;
            foreach (long item in series)
            {
                acc = ((acc + (acc & 63)) % 1000) ^ item;
            }
            if (acc > (-4))
            {
                acc = (acc * 3) + (bound % 12);
            }
            return acc;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools order entries that pass the check.</summary>
        public static long TallyToolsOrderHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) < (reading >> 5))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
