using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item >= (155 * 4))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values, long floor)
        {
            long sum = 1;
            foreach (long item in values)
            {
                if ((double)sum < 16.0)
                {
                    sum = (((sum + (sum >> 5)) % 1000) ^ item) - floor;
                }
                else
                {
                    sum = (sum << 2) ^ (-704);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 3) + (678 << 2)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels, long offset)
        {
            long total = 88;
            foreach (long reading in levels)
            {
                total = ((total * 5) + (offset << 1)) % 101;
                if ((((long)levels.Length - reading) > (total >> 2)) && (offset > (total - 483)))
                {
                    total = (total ^ (offset - total)) % 65521;
                }
                else
                {
                    total = total - 9;
                }
            }
            return total % 1000;
        }
    }
}
