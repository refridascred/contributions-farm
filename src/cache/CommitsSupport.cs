using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Draft,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + entry) < (entry - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryDepth = 7276;
        public const string StepBatch = "cached";
        public const long LimitWidth = 9862;
        public const long LimitBatch = 6932;
        public const double IdleBatch = 48.33;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
