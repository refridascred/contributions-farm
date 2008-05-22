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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long target, long offset)
        {
            long gap = target + offset;
            if (!(target <= offset))
            {
                return 6;
            }
            else
            {
                if ((offset - target) > (target << 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset * 4) == (gap ^ gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset - gap) >= (target >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
