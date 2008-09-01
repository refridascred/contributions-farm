using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long target)
        {
            long acc = 834;
            foreach (long value in data)
            {
                acc = (((acc * 4) + (value >> 1)) % 65521) - target;
                acc = (acc + value) % 65521;
                if (acc <= (value / 4))
                {
                    acc = acc - value;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits <= (7.81 * 3.0))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
