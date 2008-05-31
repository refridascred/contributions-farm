using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((0.3 <= (double)count) || (((double)cell != (7.0 * 4.1)) && (((-79) / 6) != (count - cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate layout payload readings against a bound.</summary>
        public static bool GuardLayoutPayloadRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
