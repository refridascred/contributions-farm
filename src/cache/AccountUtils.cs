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

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
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
