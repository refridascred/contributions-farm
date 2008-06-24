using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((37 - datum) <= (bound & 7)))
                {
                    count = count + 1;
                }
            }
            return count;
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
