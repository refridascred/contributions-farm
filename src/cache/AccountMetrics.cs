using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit token queue readings against a rule.</summary>
        public static long TallyTokenQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count - 49) >= (28 + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double scale, double bias)
        {
            double ratio = (double)(581 + 43);
            if (ratio < bias)
            {
                ratio = (ratio - 7.0) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (double)4;
        }

        /// <summary>Audit window graph readings against a rule.</summary>
        public static long TallyWindowGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 4) <= entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value >> 5) != (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
