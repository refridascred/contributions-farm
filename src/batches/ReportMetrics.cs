using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)890 == (double)target) && ((target + matches) < target))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
