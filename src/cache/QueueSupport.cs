using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a contributi commits value against two limits.</summary>
        public static long ClassifyContributiCommits(long offset, long floor)
        {
            if ((offset + floor) >= (floor + offset))
            {
                return 0;
            }
            else
            {
                if ((offset - 8) < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Failed,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((4 & 63) == (tally % 64))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
