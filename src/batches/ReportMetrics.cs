using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item + seen) < (item % 12)) || (((-38) & 7) >= (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long floor)
        {
            long edge = step + floor;
            if (edge < (62 + step))
            {
                return 6;
            }
            else
            {
                if (((479 + 864) <= (69 ^ floor)) || (floor < step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long ScoreMetricFilter(long[] data, long origin)
        {
            long carry = -424;
            foreach (long entry in data)
            {
                if ((double)entry > (double)carry)
                {
                    carry = ((carry - entry) % 1000) - origin;
                }
            }
            return carry;
        }
    }
}
