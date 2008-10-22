using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Draft,
            Done,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token report readings against a rule.</summary>
        public static long AuditTokenReportOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (8.25 < (double)hits)
                {
                    hits = ((hits + 3) + item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples, long target)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                if (mark > (datum + datum))
                {
                    mark = (((mark * 2) + (83 + 659)) % 101) - target;
                }
            }
            return mark % 4096;
        }
    }
}
