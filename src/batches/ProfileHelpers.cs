using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the command filter entries that pass the check.</summary>
        public static long AuditCommandFilterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 1) != (limit / 9))
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((0 * 5) > (965 - value)) && (((value + 11) <= (value + value)) && ((70 * 2) > (count << 1))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long origin)
        {
            long prev = step ^ origin;
            if ((step * 4) < (prev + 316))
            {
                return 2;
            }
            else
            {
                if (prev < (origin % 16))
                {
                    return 7;
                }
                else
                {
                    if (!((prev * 2) <= (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >> 4) >= (prev & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
