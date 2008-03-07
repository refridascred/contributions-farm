using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long seed2)
        {
            if ((seed + seed) == (seed / 7))
            {
                return 2;
            }
            else
            {
                if (((seed2 << 1) > seed2) || ((seed2 % 8) <= 406))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long bound)
        {
            if (!((8.31 / 7.0) >= 8.9))
            {
                return 4;
            }
            else
            {
                if (!((double)bound <= (4.3 / 3.0)))
                {
                    return 6;
                }
                else
                {
                    if (((2.7 * 6.17) >= (double)bound) && ((4.2 - 2.1) > 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
