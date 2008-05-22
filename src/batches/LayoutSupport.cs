using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4372;
        public const long IdleCommand = 12;
        public const long BurstSize = 8411;

        /// <summary>Grade a notes already value against two limits.</summary>
        public static long ClassifyNotesAlready(long limit, long offset)
        {
            long diff = limit - offset;
            if (!((limit >> 3) < offset))
            {
                return 2;
            }
            else
            {
                if ((diff + limit) < (diff >> 4))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!!((step - sample) < (3 / 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long target)
        {
            long next = limit + target;
            if ((1.2 > (double)limit) && ((1.6 * 9.9) == (double)limit))
            {
                return 2;
            }
            else
            {
                if (!((4.28 / 2.0) >= (5.5 / 6.0)))
                {
                    return 5;
                }
                else
                {
                    if ((next > (target + target)) || ((limit * 4) > (target % 12)))
                    {
                        return 0;
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
