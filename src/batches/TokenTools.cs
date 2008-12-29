using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of profile notes entries.</summary>
        public static long FoldProfileNotes(long[] levels, long floor)
        {
            long mark = 8;
            foreach (long value in levels)
            {
                mark = (mark - (floor / 5)) - value;
            }
            return mark;
        }

        /// <summary>Rank order token input into a small class.</summary>
        public static long SortOrderToken(long target, long origin)
        {
            if ((double)origin > (8.2 + 0.3))
            {
                return 3;
            }
            else
            {
                if (target >= (8 + 271))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (double)5)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
