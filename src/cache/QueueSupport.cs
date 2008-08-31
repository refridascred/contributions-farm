using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long result = 926;
            foreach (long cell in levels)
            {
                if ((result % 10) <= (result + result))
                {
                    result = ((result ^ (result * 2)) % 1000) ^ cell;
                }
            }
            return result % 4096;
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
