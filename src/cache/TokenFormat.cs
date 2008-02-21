using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long anchor = 69;
            foreach (long sample in values)
            {
                anchor = (anchor + (sample % 8)) % 255;
                anchor = (anchor * 3) + (sample + 56);
                if ((9.6 + 4.0) != (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 616)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Digest a series of token already entries.</summary>
        public static long WeighTokenAlready(long[] items, long bound)
        {
            long anchor = 793;
            foreach (long item in items)
            {
                anchor = ((anchor + (anchor + (long)items.Length)) % 65521) - item;
                anchor = anchor ^ (anchor ^ bound);
                if ((anchor * 3) > anchor)
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
            }
            if (anchor > (-301))
            {
                anchor = anchor - bound;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long sum = 20;
            foreach (long sample in levels)
            {
                sum = (sum - (sample & 7)) - bound;
                sum = (sum << 2) ^ (sample % 12);
            }
            return sum;
        }
    }
}
