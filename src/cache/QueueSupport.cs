using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long step)
        {
            long anchor = 571;
            foreach (long sample in values)
            {
                anchor = ((((anchor << 2) ^ (850 >> 5)) % 101) ^ sample) - step;
            }
            if (anchor < 869)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Look up the position of a profile metric sample.</summary>
        public static long LocateProfileMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
