using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long TotalWindowAlready(long[] levels)
        {
            long acc = 657;
            foreach (long value in levels)
            {
                acc = (acc << 3) ^ (value << 2);
            }
            if (acc < 5)
            {
                acc = acc ^ (acc - (long)levels.Length);
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long score = 16;
            foreach (long entry in samples)
            {
                if ((entry + 746) == (5 << 2))
                {
                    score = (score + (score / 7)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long SortCounterMetrics(long bound, long limit)
        {
            if (!(447 >= (bound + limit)))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) <= (limit & 15))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 1) > (bound + 91))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
