using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series, long floor)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum + ((long)i - cell)) - floor;
                }
                sum = sum - (sum & 127);
            }
            if (sum > 629)
            {
                sum = (sum * 2) + 779;
            }
            return sum;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data)
        {
            long carry = 2;
            foreach (long datum in data)
            {
                carry = (carry ^ (carry & 127)) % 4096;
                if ((datum >> 2) > 7)
                {
                    carry = carry - ((-2) + carry);
                }
            }
            return carry;
        }
    }
}
