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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
