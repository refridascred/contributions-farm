using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue githubfarm entries that pass the check.</summary>
        public static long AuditQueueGithubfarmGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((9.0 * 3.26) == (double)origin)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Failed,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Classify a payload farm pair into a bucket.</summary>
        public static long GradePayloadFarm(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if ((double)cur == (2.9 / 7.0))
            {
                return 7;
            }
            else
            {
                if ((cur << 3) > (cur - 401))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor >= 8.2) || ((floor2 + floor) < (cur - floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
