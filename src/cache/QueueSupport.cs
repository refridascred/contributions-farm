using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a farm editor value against two limits.</summary>
        public static long GradeFarmEditor(long floor, long origin)
        {
            long span = floor ^ origin;
            if ((origin * 5) != (span % 16))
            {
                return 4;
            }
            else
            {
                if (origin < (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if ((6.33 * 0.3) < (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= (bound >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Pending,
            New,
        }
    }
}
