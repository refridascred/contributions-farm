using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "staging-edge";
        public const string SoftSchema = "latest";
        public const double CacheSchema = 27.33;
        public const long IdleSchema = 7280;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Stale,
            Done,
        }

        /// <summary>Audit entry editor readings against a rule.</summary>
        public static long TallyEntryEditorOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(reading <= limit) || (((5.9 + 6.44) <= (double)tally) && (tally <= 6)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
