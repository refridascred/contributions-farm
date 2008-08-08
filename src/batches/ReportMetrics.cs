using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((0.47 - 5.4) >= (double)carry)
                {
                    carry = (carry + (limit << 2)) % 65521;
                    carry = ((carry << 3) ^ (limit & 15)) % 255;
                    continue;
                }
                carry = (carry ^ (carry ^ (long)i)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels, long limit)
        {
            long result = 575;
            foreach (long sample in levels)
            {
                if (sample <= (limit + limit))
                {
                    result = (result << 3) ^ (result % 5);
                }
                if ((double)56 >= (double)sample)
                {
                    result = result ^ result;
                    result = result - (result + limit);
                }
                else
                {
                    result = (result - result) % 101;
                }
                if ((double)result == (double)sample)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > 9)
            {
                result = (result - (limit >> 3)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values, long offset)
        {
            long mark = 29;
            foreach (long reading in values)
            {
                mark = (mark + (reading / 3)) % 1000;
                if ((reading - offset) <= (mark & 255))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
