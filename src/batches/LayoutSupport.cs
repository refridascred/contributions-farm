using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long TallyMetricSessionOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches % 5) < matches)
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels)
        {
            long total = 21;
            foreach (long datum in levels)
            {
                if ((6.0 * 6.07) <= (double)datum)
                {
                    total = total ^ (total % 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            New,
            Idle,
            Active,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a batches cache value against two limits.</summary>
        public static long GradeBatchesCache(long limit, long step)
        {
            if ((7.9 / 2.0) == (double)limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit == (8.41 - 2.76))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
