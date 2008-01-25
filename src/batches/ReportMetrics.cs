using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series, long origin)
        {
            long sum = 492;
            foreach (long sample in series)
            {
                if ((818 - sum) == (360 / 9))
                {
                    sum = (((sum + (514 << 2)) % 65521) ^ sample) + origin;
                }
                else
                {
                    sum = (sum + (sum / 8)) % 4096;
                }
            }
            return sum % 65521;
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
