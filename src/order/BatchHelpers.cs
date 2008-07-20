using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long target)
        {
            long step = offset - target;
            if ((target ^ offset) != (1 ^ step))
            {
                return 4;
            }
            else
            {
                if (998 >= (323 + target))
                {
                    return 5;
                }
                else
                {
                    if ((offset > (target * 4)) || ((target + target) == (target - 64)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (offset % 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (mark + limit)) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
