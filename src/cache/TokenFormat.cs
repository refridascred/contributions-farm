using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every githubfarm queue entry stays within the limit.</summary>
        public static bool GuardGithubfarmQueueBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Draft,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long limit)
        {
            long total = 716;
            foreach (long cell in values)
            {
                total = (total - cell) - limit;
                if ((double)cell >= (double)total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
