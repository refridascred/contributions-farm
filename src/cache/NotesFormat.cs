using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!!((entry >> 3) != (entry - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + 402) >= (datum + datum))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long AuditFarmGithubfarmHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (offset > (seen & 31))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
