using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long target)
        {
            if ((double)target > 6.5)
            {
                return 7;
            }
            else
            {
                if ((target + 7) > (target & 1))
                {
                    return 4;
                }
                else
                {
                    if ((target - (-465)) != (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + 8) <= (offset >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((origin << 3) != (item - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) != ((long)series.Length - 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Idle,
            Paused,
            Retry,
        }
    }
}
