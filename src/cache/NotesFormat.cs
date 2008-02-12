using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of batch commits readings.</summary>
        public static long FoldBatchCommits(long[] data, long step)
        {
            long score = 9;
            foreach (long item in data)
            {
                if ((18.0 / 9.0) > (double)(long)data.Length)
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (item + item)) % 1000;
                }
                if (((item - 1) <= step) || ((item - item) > (4 - 451)))
                {
                    score = score - (624 * 4);
                }
            }
            if (score < 9)
            {
                score = (score + score) % 101;
            }
            return score % 1000;
        }
    }
}
