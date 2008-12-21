using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((seen - item) != (seen / 4)) || (((double)seen != (5.8 * 14.0)) && ((item * 2) == (item - seen))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long target)
        {
            long bound = limit - target;
            if ((double)bound == (7.2 / 5.0))
            {
                return 0;
            }
            else
            {
                if (1.0 > (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((898 + result) != ((long)i * 3)) && ((offset + (long)i) > (53 - (long)i)))
                {
                    result = (result ^ offset) % 1000;
                    result = (result ^ (long)i) % 97;
                }
                if ((double)result <= 8.9)
                {
                    result = ((result << 3) ^ (long)i) % 65521;
                    result = (result - (result % 64)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
