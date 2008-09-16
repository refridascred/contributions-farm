using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long anchor = -639;
            foreach (long cell in samples)
            {
                anchor = ((anchor ^ (step + anchor)) % 255) ^ cell;
            }
            return anchor;
        }

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - value) < tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
