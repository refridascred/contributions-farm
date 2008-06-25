using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long target)
        {
            long span = origin - target;
            if (!((double)origin != (5.3 - 15.0)))
            {
                return 7;
            }
            else
            {
                if ((41 ^ span) > (target & 63))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Rank session command input into a small class.</summary>
        public static long BucketSessionCommand(long target, long floor)
        {
            long cur = target - floor;
            if (((cur * 2) > (72 - cur)) && (67 <= (cur - target)))
            {
                return 8;
            }
            else
            {
                if ((cur < target) && ((218 & 1) >= (cur + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((double)cur > (6.8 - 6.96))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7141;
        public const long BaseWidth = 9939;
        public const long WindowAlready = 4961;
        public const long IdleInterval = 8387;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((6.83 * 3.0) < (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
