using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(count > (count / 4)))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(offset < count))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
