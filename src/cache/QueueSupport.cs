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

        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long RankFormatSchema(long step, long limit)
        {
            long gap = step ^ limit;
            if ((limit >> 4) <= step)
            {
                return 0;
            }
            else
            {
                if (((double)limit <= (3.0 - 9.6)) && ((limit ^ limit) >= (gap / 2)))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) > (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (3.0 >= (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
