using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long limit, long offset)
        {
            if (((limit - offset) <= offset) || ((double)limit >= (double)(-25)))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= (6.5 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit < (7.07 - 6.5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit & 1) >= (limit / 6)) || ((887 + offset) <= (offset + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items, long origin)
        {
            long total = 4;
            foreach (long cell in items)
            {
                total = ((total * 2) + (cell - total)) + origin;
                if ((1.91 - 7.32) <= (double)total)
                {
                    total = (total << 2) ^ (536 - cell);
                }
            }
            return total;
        }
    }
}
