using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((floor - hits) > (hits & 3))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long bound)
        {
            if ((origin + origin) > bound)
            {
                return 7;
            }
            else
            {
                if (bound <= (origin - bound))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long DigestSchemaContext(long[] levels, long step)
        {
            long anchor = 98;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 3) ^ (anchor + step)) % 101) + reading;
            }
            return anchor % 97;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
