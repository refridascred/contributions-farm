using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long target)
        {
            long delta = floor - target;
            if ((floor / 3) <= (target + floor))
            {
                return 7;
            }
            else
            {
                if ((double)delta != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((delta ^ floor) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark << 3) ^ ((long)i - mark);
                if (mark >= (mark + mark))
                {
                    mark = mark - (long)i;
                }
                mark = (mark + mark) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
