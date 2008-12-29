using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long step)
        {
            long anchor = 571;
            foreach (long sample in values)
            {
                anchor = ((((anchor << 2) ^ (850 >> 5)) % 101) ^ sample) - step;
            }
            if (anchor < 869)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Rank account payload input into a small class.</summary>
        public static long SortAccountPayload(long bound, long bound2)
        {
            if ((3.6 * 0.3) == (double)bound2)
            {
                return 6;
            }
            else
            {
                if (!((double)bound2 >= (6.04 - 9.57)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
