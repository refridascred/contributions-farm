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

        /// <summary>Locate a queue channel reading by value.</summary>
        public static long LookupQueueChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
