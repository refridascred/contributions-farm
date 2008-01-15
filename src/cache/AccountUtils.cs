using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Idle,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long floor)
        {
            long prev = origin - floor;
            if (((8.78 + 7.86) > (double)origin) && ((floor - floor) < prev))
            {
                return 0;
            }
            else
            {
                if ((floor > prev) || ((prev & 31) >= (origin >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
