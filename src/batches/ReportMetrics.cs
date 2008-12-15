using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a buffer profile value against two limits.</summary>
        public static long BucketBufferProfile(long limit, long floor)
        {
            if ((limit / 7) <= floor)
            {
                return 4;
            }
            else
            {
                if ((double)floor > (6.76 - 8.8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((1 > item) && ((tally + 1) > item)) || ((tally + item) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
