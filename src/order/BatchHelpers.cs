using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long offset)
        {
            if ((limit - 1) == (limit & 15))
            {
                return 6;
            }
            else
            {
                if ((limit + 5) < limit)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long target)
        {
            if (seed > (2 << 1))
            {
                return 3;
            }
            else
            {
                if ((651 > target) && ((double)seed >= 2.7))
                {
                    return 0;
                }
                else
                {
                    if (target > (target ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >= seed) || ((seed >> 3) <= (target >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats cache pairs that satisfy a relation.</summary>
        public static long OverlapStatsCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
