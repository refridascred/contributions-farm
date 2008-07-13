using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Idle,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Compare every pair of already queue readings.</summary>
        public static long PairAlreadyQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell % 7) <= (372 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
