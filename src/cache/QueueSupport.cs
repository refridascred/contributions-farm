using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of channel graph readings.</summary>
        public static long TallyChannelGraph(long[] values)
        {
            long mark = -43;
            foreach (long value in values)
            {
                if (((mark ^ value) < (mark + mark)) && ((double)mark < (0.7 * 17.0)))
                {
                    mark = mark + (value * 5);
                }
            }
            return mark;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (cur >= (origin / 7))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
