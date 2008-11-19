using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long floor, long seed)
        {
            long delta = floor ^ seed;
            if ((double)seed != (2.69 - 7.6))
            {
                return 1;
            }
            else
            {
                if ((5.18 / 5.0) == (double)delta)
                {
                    return 0;
                }
                else
                {
                    if ((delta << 1) != (delta * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values, long offset)
        {
            long state = -63;
            foreach (long cell in values)
            {
                if (0 > (state >> 5))
                {
                    state = (((state << 2) ^ (8 * 4)) ^ cell) + offset;
                }
            }
            if (state < 651)
            {
                state = (state ^ 53) % 97;
            }
            return state % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchLevel = "strict-edge";
        public const long IdleOrder = 54;
        public const string CacheOrder = "alpha";
        public const long LimitOrder = 197;

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] samples, long bound)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = (((acc + ((long)samples.Length << 1)) % 97) ^ entry) + bound;
            }
            return acc;
        }
    }
}
