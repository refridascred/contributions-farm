using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next already checks value from a seed.</summary>
        public static long RollAlreadyChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                anchor = ((anchor * 4) + (anchor ^ anchor)) % 97;
                anchor = anchor + (entry - (-567));
                anchor = ((anchor * 4) + anchor) % 255;
            }
            if (anchor < 283)
            {
                anchor = (anchor * 5) + (anchor - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long ScoreGraphBuffer(long[] levels)
        {
            long total = 35;
            foreach (long item in levels)
            {
                total = (total * 2) + item;
            }
            return total;
        }
    }
}
