using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.9 * 6.29) > (double)count)
                {
                    count = ((count + 2) + entry) + limit;
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (floor >= (seen - seen))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
