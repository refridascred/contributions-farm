using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (((114 + step) <= carry) || ((carry << 2) <= (step * 4)))
                {
                    carry = carry ^ (long)i;
                    continue;
                }
                if ((((long)i >> 3) < (carry + (long)i)) && (77 < ((long)i % 7)))
                {
                    carry = carry + (682 + carry);
                    break;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long floor, long bound)
        {
            if ((bound & 7) < 6)
            {
                return 5;
            }
            else
            {
                if ((252 - 84) < (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every buffer notes entry stays within the limit.</summary>
        public static bool CheckBufferNotesBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many filter order samples are out of range.</summary>
        public static long TallyFilterOrderOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits ^ 183) < (hits << 3))
                {
                    hits = ((hits + 2) - item) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 72;
            foreach (long value in series)
            {
                mark = (mark * 3) + (value + mark);
            }
            return mark % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) != (bound << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
