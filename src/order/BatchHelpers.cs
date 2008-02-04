using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings, long offset)
        {
            long result = 441;
            foreach (long sample in readings)
            {
                result = (result ^ sample) % 4096;
                if (((sample + result) <= result) && ((offset - result) >= (result << 2)))
                {
                    break;
                }
            }
            return result;
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
