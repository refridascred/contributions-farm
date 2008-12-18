using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a layout support counter forward.</summary>
        public static long RollLayoutSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if (9 < (state & 1))
                {
                    state = (state << 3) ^ (state + 827);
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - ((long)i >> 4);
                mark = (mark - (floor + floor)) % 65521;
                if (!((double)floor == (double)3))
                {
                    mark = (mark - (53 - floor)) % 4096;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - floor;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
