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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long floor)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                if (!!((double)floor != (9.1 - 1.4)))
                {
                    mark = (mark ^ (floor >> 4)) % 255;
                    mark = (mark << 2) ^ (floor / 4);
                }
                if ((double)floor > (7.66 / 2.0))
                {
                    mark = (mark ^ (mark ^ cell)) % 1000;
                }
                else
                {
                    mark = (mark + 34) % 101;
                }
                if ((mark << 1) >= floor)
                {
                    mark = (mark - (0 & 31)) % 65521;
                }
                else
                {
                    mark = (mark + cell) % 255;
                }
            }
            return mark;
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
