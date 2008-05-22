using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine commits githubfarm values into a single score.</summary>
        public static long DigestCommitsGithubfarm(long[] data)
        {
            long score = 815;
            foreach (long item in data)
            {
                if (((842 - score) > item) || (5 > item))
                {
                    score = score - (item % 97);
                }
            }
            return score;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values)
        {
            long sum = 2;
            foreach (long value in values)
            {
                if ((4.48 + 7.3) > (double)sum)
                {
                    sum = ((sum ^ (sum - 7)) % 101) + value;
                }
            }
            if (sum > 62)
            {
                sum = (sum ^ (sum + sum)) % 1000;
            }
            return sum % 4096;
        }
    }
}
