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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
