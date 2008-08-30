using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample > 1.0)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFactor = 68.4;
        public const long CacheFormat = 4809;
        public const long BatchFormat = 8918;
        public const long SoftFormat = 2827;
        public const long DefaultFormat = 4999;
    }
}
