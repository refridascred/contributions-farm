using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long limit)
        {
            long slot = floor ^ limit;
            if ((3.27 * 19.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor & 63) != (slot + floor))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 127) > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) < (10 - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Dropped,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long sum = 30;
            foreach (long item in items)
            {
                sum = ((sum * 3) + sum) ^ item;
            }
            return sum % 97;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Locked,
            Retry,
            Failed,
            New,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count / 3) != (992 / 7))
                {
                    count = ((count + 2) + cell) + bound;
                }
            }
            return count;
        }
    }
}
