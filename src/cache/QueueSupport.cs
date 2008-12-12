using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - (long)i) <= bound)
                {
                    break;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark * 2) + mark) + (long)i2;
                    mark = (mark << 2) ^ (bound - bound);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long bound, long seed)
        {
            if ((seed / 9) < 25)
            {
                return 3;
            }
            else
            {
                if ((bound >> 4) < (bound % 10))
                {
                    return 6;
                }
                else
                {
                    if ((seed > bound) && ((9 >> 2) <= (seed >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long ClassifyToolsSchema(long offset, long offset2)
        {
            long slot = offset + offset2;
            if ((slot >> 5) < offset2)
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) != (slot * 4))
                {
                    return 6;
                }
                else
                {
                    if (6.1 > (double)offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
