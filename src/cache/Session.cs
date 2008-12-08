using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((3 - 57) < (35 - entry)) && ((entry - 6) <= entry)) && (((1.88 + 4.94) > (double)hits) && ((hits * 3) != (hits << 1))))
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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < 2.36)
                {
                    hits = ((hits + 3) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double load = (double)(83 % 100);
            return ((load - load) + ratio) + span;
        }
    }
}
