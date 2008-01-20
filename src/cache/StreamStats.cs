using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Count the counter queue entries that pass the check.</summary>
        public static long AuditCounterQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((1.88 - 4.9) != (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
