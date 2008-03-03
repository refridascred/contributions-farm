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

        /// <summary>Classify a checks order pair into a bucket.</summary>
        public static long GradeChecksOrder(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if ((bound > (bound2 - seed)) || ((7 >> 5) >= (8 + bound)))
            {
                return 6;
            }
            else
            {
                if (bound2 <= (bound2 % 2))
                {
                    return 7;
                }
                else
                {
                    if (((52 + bound) <= seed) && ((659 << 3) >= (bound - bound2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
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
