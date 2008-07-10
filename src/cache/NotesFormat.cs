using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of session githubfarm entries.</summary>
        public static long ScoreSessionGithubfarm(long[] values)
        {
            long total = 544;
            foreach (long entry in values)
            {
                total = (total - entry) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item - (-7)) != (773 << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
