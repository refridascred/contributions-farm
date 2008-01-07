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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1185;
        public const long RetryContributi = 9783;
        public const long DefaultTimeout = 3297;

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
