using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a tools filter pair into a bucket.</summary>
        public static long BucketToolsFilter(long step, long seed)
        {
            if (((3.7 * 4.93) > (double)step) && ((seed ^ step) <= (step & 3)))
            {
                return 7;
            }
            else
            {
                if (step < (875 / 4))
                {
                    return 2;
                }
                else
                {
                    if (seed > (seed + 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item / 6) > (seen + 34))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
