using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (8 <= (sample * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)step >= (1.19 - 8.3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = ((score << 3) ^ (sample >> 2)) % 101;
                score = (score << 2) ^ (score - score);
            }
            return score % 1000;
        }
    }
}
