using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many tools context samples are out of range.</summary>
        public static long TallyToolsContextOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((1 & 63) > (entry >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data, long origin)
        {
            long mix = 812;
            foreach (long reading in data)
            {
                if ((double)origin <= (double)mix)
                {
                    mix = ((mix * 4) + (origin + (-91))) + reading;
                }
                else
                {
                    mix = ((mix << 3) ^ origin) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
