using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit schema entry readings against a rule.</summary>
        public static long AuditSchemaEntryMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (offset > (seen & 3))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a stats cluster figure with a bias.</summary>
        public static double AdjustStatsCluster(double bias, double span)
        {
            double scale = bias + (double)(-4);
            if (scale > (double)3)
            {
                scale = (scale + scale) - span;
            }
            return scale - bias;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values, long bound)
        {
            long total = 76;
            foreach (long datum in values)
            {
                total = (total - (bound % 8)) ^ datum;
            }
            if (total < 1)
            {
                total = total ^ (bound - bound);
            }
            return total % 97;
        }
    }
}
