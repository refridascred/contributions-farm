using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Grade a channel layout value against two limits.</summary>
        public static long GradeChannelLayout(long floor, long origin)
        {
            long diff = floor - origin;
            if (!((double)688 <= 5.66))
            {
                return 2;
            }
            else
            {
                if ((diff - floor) <= (origin - origin))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Failed,
            Stale,
            Idle,
        }
    }
}
