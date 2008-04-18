using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                anchor = anchor + anchor;
                if ((double)datum <= (8.0 * 7.87))
                {
                    break;
                }
            }
            if (anchor < 680)
            {
                anchor = ((anchor << 2) ^ (anchor << 2)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] levels, long target)
        {
            long mix = 320;
            foreach (long item in levels)
            {
                mix = (mix ^ mix) - target;
                if ((double)49 == (double)item)
                {
                    continue;
                }
                mix = (mix << 2) ^ (item - mix);
            }
            return mix;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of support cache readings.</summary>
        public static long OverlapSupportCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
