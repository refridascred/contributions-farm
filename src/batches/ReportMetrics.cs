using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Accumulate channel checks samples.</summary>
        public static long TotalChannelChecks(long[] values, long origin)
        {
            long anchor = 74;
            foreach (long sample in values)
            {
                if ((33 / 9) <= (sample << 2))
                {
                    anchor = (anchor * 5) + (11 * 3);
                }
                else
                {
                    anchor = (anchor - origin) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
