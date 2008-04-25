using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long offset)
        {
            long delta = bound + offset;
            if ((bound - delta) < (delta >> 1))
            {
                return 1;
            }
            else
            {
                if (delta > (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 3) >= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta + bound) <= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)origin <= 4.9)
                {
                    carry = carry ^ ((-317) + origin);
                    carry = (carry ^ (carry / 6)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
