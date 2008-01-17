using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 3) >= (cell << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool GuardClusterNotesLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count report entry pairs that satisfy a relation.</summary>
        public static long MatchReportEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Closed,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 6399;
        public const long CacheGithubfarm = 6864;
        public const long SoftScore = 4807;
        public const long WindowGithubfarm = 1624;
    }
}
