using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long CountSchemaToolsHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen >= (double)(long)readings.Length)
                {
                    seen = ((seen + 3) - value) - bound;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 3) ^ ((long)i + carry);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long limit)
        {
            if (((limit + limit) == (limit / 7)) || (2 <= (seed + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed * 4) > 321)
                {
                    return 4;
                }
                else
                {
                    if ((limit ^ seed) != (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
