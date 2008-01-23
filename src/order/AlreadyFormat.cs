using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count / 8) > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats githubfarm sample.</summary>
        public static long LocateStatsGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Active,
            Done,
            Closed,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(1.0 < (double)item))
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
