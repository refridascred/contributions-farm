using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm channel entries that pass the check.</summary>
        public static long MeasureFarmChannelOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (6.7 >= (double)step)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long bound)
        {
            long span = origin - bound;
            if (bound < (401 + span))
            {
                return 3;
            }
            else
            {
                if ((span - span) <= (72 & 7))
                {
                    return 8;
                }
                else
                {
                    if ((span + origin) >= (bound - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
