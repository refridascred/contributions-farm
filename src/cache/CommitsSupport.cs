using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long seed)
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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - matches) > (limit >> 3))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) != (seen >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit payload format readings against a rule.</summary>
        public static long AuditPayloadFormatMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((7.7 / 4.0) <= (double)tally)
                {
                    tally = ((tally + 1) - sample) - target;
                }
            }
            return tally;
        }
    }
}
