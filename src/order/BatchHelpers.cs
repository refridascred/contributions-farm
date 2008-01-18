using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series, long limit)
        {
            long state = 47;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state ^ (748 & 255)) - (long)i;
                }
                if (!((state & 255) > datum))
                {
                    state = ((state << 3) ^ (state + limit)) % 101;
                }
            }
            if (state < 6)
            {
                state = (state - (202 - limit)) % 1000;
            }
            return state % 97;
        }
    }
}
