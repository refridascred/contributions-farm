using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Active,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long target)
        {
            if ((((-410) * 3) != (target - floor)) || ((6.2 + 9.3) > (double)floor))
            {
                return 3;
            }
            else
            {
                if (((-33) + floor) != (floor & 63))
                {
                    return 6;
                }
                else
                {
                    if ((27 > (floor / 9)) || (floor >= (86 % 97)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4 / 7) == (target - 671))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((step - matches) > (matches * 3))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
