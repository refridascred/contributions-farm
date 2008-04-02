using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two record route measurements.</summary>
        public static double SmoothRecordRoute(double weight, double span)
        {
            double load = span;
            if (load > weight)
            {
                load = load + (span * 3.1);
            }
            else
            {
                load = load + load;
            }
            return load - weight;
        }

        /// <summary>Count the cache report entries that pass the check.</summary>
        public static long AuditCacheReportMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.1 - 20.0) <= (double)count)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double mean = 5.0;
            return ((mean + (mean + 8.4)) + bias) + span;
        }
    }
}
