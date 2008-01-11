using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit session already readings against a rule.</summary>
        public static long AuditSessionAlreadyOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (49 <= (offset - seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Draft,
            Retry,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (75 <= (long)levels.Length)
                {
                    hits = ((hits + 2) - entry) - bound;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long seed, long step)
        {
            long offset = seed + step;
            if ((step + (-90)) <= (step / 7))
            {
                return 7;
            }
            else
            {
                if (offset <= (seed - offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate already format readings against a bound.</summary>
        public static bool CheckAlreadyFormatRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
