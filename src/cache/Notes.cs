using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Draft,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long bound)
        {
            long sum = 2;
            foreach (long datum in levels)
            {
                if ((datum >= (datum + 655)) && ((double)bound == (3.39 + 17.0)))
                {
                    sum = (sum ^ (sum % 100)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Measure how many account batches samples are out of range.</summary>
        public static long TallyAccountBatchesHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((0.27 <= (double)target) && ((target > (0 << 2)) || ((11 + entry) <= (entry + seen))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
