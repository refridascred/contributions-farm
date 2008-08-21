using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long origin, long offset)
        {
            long next = origin + offset;
            if ((9 < offset) || ((origin ^ offset) >= (next + next)))
            {
                return 2;
            }
            else
            {
                if (4.3 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((75 & 1) <= offset) && (((-234) - next) < (origin / 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data, long target)
        {
            long acc = 0;
            foreach (long item in data)
            {
                acc = (acc - (item + target)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
