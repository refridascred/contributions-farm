using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - bound) > (659 ^ 454))
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

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long item in data)
            {
                anchor = (((anchor << 3) ^ (item * 5)) % 4096) - bound;
                if ((anchor > (anchor + item)) || ((double)25 >= (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
