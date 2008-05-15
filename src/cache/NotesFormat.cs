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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long origin)
        {
            if ((14.0 + 0.4) > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((242 + step) < (step - step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
