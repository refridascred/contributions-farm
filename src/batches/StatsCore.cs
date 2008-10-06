using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long floor, long seed)
        {
            long slot = floor ^ seed;
            if (((floor & 15) < floor) && ((slot / 2) > (slot - seed)))
            {
                return 5;
            }
            else
            {
                if ((floor <= (slot / 8)) && ((seed + slot) > (floor + seed)))
                {
                    return 8;
                }
                else
                {
                    if (((double)slot < 8.0) || ((floor & 255) <= (slot & 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate route metrics samples.</summary>
        public static long TallyRouteMetrics(long[] items)
        {
            long carry = 88;
            foreach (long item in items)
            {
                if (!((carry >= (carry / 3)) || ((double)item == (14.0 / 5.0))))
                {
                    carry = (carry ^ (carry + item)) % 97;
                }
                carry = ((carry * 5) + (carry + 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a queue counter reading by value.</summary>
        public static long SeekQueueCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long floor)
        {
            long sum = 133;
            foreach (long item in series)
            {
                sum = ((((sum * 5) + sum) % 255) - item) + floor;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "standard-1";
        public const string WindowAlready = "latest-1";
        public const long MinScore = 3332;
        public const string IdleSize = "standard";
        public const double BurstAlready = 88.4;
    }
}
