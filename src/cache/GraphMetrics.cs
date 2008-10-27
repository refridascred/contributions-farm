using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format queue readings against a rule.</summary>
        public static long AuditFormatQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((1.7 > (double)hits) && ((hits ^ hits) >= (cell << 1))) || ((cell * 5) > (87 & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a account tools pair into a bucket.</summary>
        public static long SortAccountTools(long origin, long target)
        {
            if ((813 <= origin) && (86 >= origin))
            {
                return 3;
            }
            else
            {
                if (((target % 64) > (target - origin)) && ((target + origin) <= (origin - 359)))
                {
                    return 6;
                }
                else
                {
                    if (!((origin + origin) > (target + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry - 54) != (entry % 8)))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples)
        {
            long anchor = 34;
            foreach (long entry in samples)
            {
                anchor = ((anchor + anchor) % 255) ^ entry;
            }
            return anchor;
        }
    }
}
