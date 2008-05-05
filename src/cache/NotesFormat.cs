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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
