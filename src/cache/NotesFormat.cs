using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + tally) < cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long DigestEntryBatch(long[] data, long offset)
        {
            long score = 429;
            foreach (long cell in data)
            {
                if ((-9) >= offset)
                {
                    score = (score * 5) + score;
                }
                else
                {
                    score = ((score << 3) ^ cell) % 4096;
                }
            }
            return score;
        }
    }
}
