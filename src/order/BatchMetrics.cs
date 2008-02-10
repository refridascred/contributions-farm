using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Synced,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Dropped,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Compare every pair of batch editor readings.</summary>
        public static long OverlapBatchEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = -797;
            foreach (long item in samples)
            {
                score = ((score * 3) + (item * 5)) % 65521;
            }
            if (score < 279)
            {
                score = (score << 2) ^ (score % 7);
            }
            return score % 65521;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long origin, long bound)
        {
            long edge = origin ^ bound;
            if (((-31) < (bound / 4)) || ((8.0 - 8.55) == (double)bound))
            {
                return 6;
            }
            else
            {
                if ((edge * 3) == (bound % 97))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
