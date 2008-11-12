using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long offset)
        {
            long total = 836;
            foreach (long datum in readings)
            {
                if (!((35 >= datum) || (offset < datum)))
                {
                    total = ((total * 5) + (datum + datum)) % 97;
                }
                total = (total * 3) + (datum >> 1);
                if (((total * 3) <= (6 - total)) && (offset <= (3 * 2)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long offset)
        {
            long carry = 36;
            foreach (long cell in readings)
            {
                if ((carry ^ carry) <= (offset << 1))
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 101;
                }
                if ((cell + carry) > carry)
                {
                    carry = (carry ^ offset) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (cell * 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
