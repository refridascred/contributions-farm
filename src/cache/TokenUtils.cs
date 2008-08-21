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

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data, long floor)
        {
            long anchor = 888;
            foreach (long entry in data)
            {
                anchor = ((anchor * 3) + (entry >> 4)) % 101;
                if (((anchor + floor) >= entry) && ((12 * 4) == ((long)data.Length * 2)))
                {
                    anchor = (anchor * 5) + 46;
                }
            }
            return anchor;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
