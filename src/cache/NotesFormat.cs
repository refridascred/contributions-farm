using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate buffer queue readings against a bound.</summary>
        public static bool GuardBufferQueueRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell > (cell & 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) > (count - 1))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
