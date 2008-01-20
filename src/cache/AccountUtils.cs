using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Synced,
            Retry,
            Ready,
            New,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long bound)
        {
            if (((double)origin >= (3.92 + 9.69)) || ((bound + bound) >= origin))
            {
                return 3;
            }
            else
            {
                if (((double)origin <= (6.0 - 4.52)) && ((bound * 3) < origin))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 4) != (bound % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Draft,
            Pending,
            Locked,
            New,
        }
    }
}
