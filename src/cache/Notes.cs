using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long state = -2;
            foreach (long entry in readings)
            {
                if (!(9.6 > (double)state))
                {
                    state = (state ^ (entry - entry)) % 101;
                }
                else
                {
                    state = state ^ (entry + state);
                }
            }
            return state;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 26;
        public const long MaxSize = 1607;
        public const long WindowLevel = 3317;
        public const double LimitWidth = 89.94;
        public const string MaxScore = "primary-1";

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                if ((double)cell != (double)mark)
                {
                    mark = ((mark << 3) ^ (cell ^ mark)) % 97;
                }
                if (mark < (cell + mark))
                {
                    mark = (mark + (cell - 8)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long offset)
        {
            long anchor = 550;
            foreach (long item in levels)
            {
                if ((double)item > 8.7)
                {
                    anchor = ((anchor * 4) + (1 % 2)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + (offset + offset)) % 65521;
                }
            }
            if (anchor > 251)
            {
                anchor = (anchor + (offset + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
