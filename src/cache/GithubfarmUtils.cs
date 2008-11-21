using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a queue session value against two limits.</summary>
        public static long BucketQueueSession(long offset, long limit)
        {
            long cur = offset ^ limit;
            if (offset < (cur >> 1))
            {
                return 3;
            }
            else
            {
                if ((cur % 3) <= (8 % 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit == (20.0 + 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally >> 1) >= (tally ^ 2))
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Dropped,
            Queued,
            Closed,
            Locked,
        }
    }
}
