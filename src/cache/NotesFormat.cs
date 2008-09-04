using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long score = 5;
            foreach (long cell in readings)
            {
                if ((1.74 - 8.31) != (double)cell)
                {
                    score = (score * 4) + (cell << 2);
                }
            }
            if (score < 3)
            {
                score = ((score * 3) + (410 + score)) % 97;
            }
            return score;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Failed,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
