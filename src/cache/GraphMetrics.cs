using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values, long limit)
        {
            long state = 27;
            foreach (long value in values)
            {
                state = (state ^ (value >> 5)) + limit;
            }
            if (state > 6)
            {
                state = ((state * 3) + (state << 1)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long mark = -950;
            foreach (long entry in values)
            {
                if ((6.4 * 3.0) != (double)mark)
                {
                    mark = (((mark ^ (long)values.Length) % 1000) + entry) + offset;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] values)
        {
            long carry = -771;
            foreach (long value in values)
            {
                if ((value - value) > (35 - carry))
                {
                    carry = carry ^ (value - carry);
                }
                else
                {
                    carry = (carry - (value - 4)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum ^ (sum & 7)) - (long)i;
                    sum = (sum + (sum ^ 2)) % 1000;
                }
                if ((3.8 - 12.0) > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
