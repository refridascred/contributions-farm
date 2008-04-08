using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long step)
        {
            long sum = 835;
            foreach (long cell in values)
            {
                if (!(((6.67 + 8.88) <= (double)sum) && ((double)cell == (9.6 - 4.46))))
                {
                    sum = (sum * 5) + (sum - step);
                }
                if ((step % 12) > sum)
                {
                    sum = (sum - (-965)) % 1000;
                }
                sum = (sum - (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long CountQueueToolsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits * 4) > (866 + hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Pending,
            New,
            Done,
            Draft,
        }
    }
}
