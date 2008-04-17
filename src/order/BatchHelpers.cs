using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long seed)
        {
            long prev = offset ^ seed;
            if (((prev + seed) <= seed) && ((3.7 / 6.0) != (double)offset))
            {
                return 0;
            }
            else
            {
                if ((615 + 99) > (prev + seed))
                {
                    return 3;
                }
                else
                {
                    if ((prev - prev) <= (seed + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (prev > (prev * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum + (34 + target)) % 101) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
