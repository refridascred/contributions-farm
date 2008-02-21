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

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Stale,
            Draft,
            Ready,
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
