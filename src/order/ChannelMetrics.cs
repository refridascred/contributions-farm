using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long target)
        {
            if ((target >> 2) <= (origin & 127))
            {
                return 8;
            }
            else
            {
                if (((double)target != (5.17 / 6.0)) || ((double)origin > (4.7 - 4.0)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state ^ seed) ^ (long)i2;
                    state = (state + ((long)i * 3)) % 255;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark << 3) ^ 57) ^ (long)i2;
                }
                if (((mark * 3) <= (floor + (long)i)) || (((long)i / 9) <= mark))
                {
                    mark = (mark << 2) ^ (79 % 12);
                }
                else
                {
                    mark = mark + (mark >> 1);
                    mark = mark ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
