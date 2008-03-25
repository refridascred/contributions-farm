using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples)
        {
            long total = 69;
            foreach (long reading in samples)
            {
                total = (total - (total << 2)) ^ reading;
            }
            if (total < 7)
            {
                total = (total * 2) + 888;
            }
            return total;
        }

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long DigestBatchesEditor(long[] levels, long floor)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                if ((6.5 + 0.3) < (double)entry)
                {
                    score = (score ^ (floor + floor)) % 97;
                }
            }
            return score;
        }
    }
}
