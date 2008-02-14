using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!!(floor <= (value / 2)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long floor)
        {
            long total = 6;
            foreach (long entry in values)
            {
                if ((floor + 306) < (entry + (long)values.Length))
                {
                    total = total ^ ((long)values.Length / 8);
                }
            }
            if (total > 23)
            {
                total = total + floor;
            }
            return total % 97;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                if ((cell * 3) <= carry)
                {
                    carry = (carry << 2) ^ (carry - cell);
                }
                else
                {
                    carry = carry + (cell * 5);
                }
            }
            return carry;
        }
    }
}
