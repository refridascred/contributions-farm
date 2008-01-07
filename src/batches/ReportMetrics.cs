using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            long offset2 = offset + origin;
            if (((offset * 4) != (offset * 2)) && (offset2 > (offset2 ^ offset)))
            {
                return 8;
            }
            else
            {
                if ((offset2 + origin) != (77 ^ origin))
                {
                    return 2;
                }
                else
                {
                    if (offset2 >= (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
