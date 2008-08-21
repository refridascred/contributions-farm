using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Done,
            Failed,
            Dropped,
            Paused,
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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long offset, long limit)
        {
            long slot = offset - limit;
            if ((slot < (slot << 2)) && (6 >= offset))
            {
                return 4;
            }
            else
            {
                if (!((limit - limit) > offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
