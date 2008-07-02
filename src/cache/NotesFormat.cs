using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Dropped,
            New,
            Synced,
            Paused,
        }

        /// <summary>Classify a checks filter pair into a bucket.</summary>
        public static long SortChecksFilter(long seed, long target)
        {
            if ((1.0 + 20.0) != (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)seed < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long origin)
        {
            if ((seed >> 5) < seed)
            {
                return 6;
            }
            else
            {
                if (seed <= (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
