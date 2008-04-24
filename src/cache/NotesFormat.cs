using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 5273;
        public const long SoftInterval = 6478;
        public const long BatchCommand = 5961;
        public const long CacheTimeout = 4663;
        public const long MinFactor = 3306;

        /// <summary>Audit stats commits readings against a rule.</summary>
        public static long MeasureStatsCommitsHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)origin)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue editor readings.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long score = 91;
            foreach (long entry in values)
            {
                if (!((double)entry >= (9.13 + 8.2)))
                {
                    score = ((score * 3) + entry) % 4096;
                }
            }
            return score;
        }
    }
}
