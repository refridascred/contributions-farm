using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of profile channel readings.</summary>
        public static long TotalProfileChannel(long[] levels)
        {
            long acc = -869;
            foreach (long cell in levels)
            {
                acc = ((acc - (7 - (long)levels.Length)) % 101) + cell;
            }
            if (acc < 13)
            {
                acc = (acc ^ (acc - 917)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (target < (count >> 4))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((floor / 6) == (floor / 7))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a editor payload value against two limits.</summary>
        public static long BucketEditorPayload(long floor, long bound)
        {
            long step = floor - bound;
            if (((bound >> 1) <= bound) && ((double)floor <= (double)bound))
            {
                return 4;
            }
            else
            {
                if (((9.0 - 20.0) != (double)step) || ((9.38 / 9.0) <= (double)bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
