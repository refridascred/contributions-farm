using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long FoldSessionSupport(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                anchor = (anchor * 2) + (cell + anchor);
            }
            return anchor;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long floor)
        {
            long diff = offset + floor;
            if (4 < (offset - diff))
            {
                return 8;
            }
            else
            {
                if (((double)diff < (20.0 * 2.96)) || ((floor - floor) != (offset << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((3 + offset) > (floor - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
