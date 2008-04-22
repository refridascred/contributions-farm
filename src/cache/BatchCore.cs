using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Locked,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                anchor = ((anchor + anchor) % 65521) - item;
            }
            return anchor;
        }

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long AuditFormatNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally > (item ^ 14))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
