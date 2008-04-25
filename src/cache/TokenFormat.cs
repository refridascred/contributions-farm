using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long target)
        {
            long delta = floor ^ target;
            if ((floor >> 2) < (delta - 361))
            {
                return 4;
            }
            else
            {
                if ((target + delta) < target)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine order window values into a single score.</summary>
        public static long ScoreOrderWindow(long[] readings, long limit)
        {
            long carry = 32;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry + ((long)i ^ carry)) % 101) + cell) - limit;
                }
                carry = ((carry << 2) ^ (carry & 255)) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target ^ target) <= total)
                {
                    total = ((total * 3) + ((long)i << 2)) % 4096;
                }
                total = total - (target * 2);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
