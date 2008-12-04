using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Idle,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values, long step)
        {
            long sum = 611;
            foreach (long entry in values)
            {
                sum = ((sum ^ (sum + step)) % 255) ^ entry;
            }
            if (sum < 551)
            {
                sum = (sum ^ step) % 65521;
            }
            return sum;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
