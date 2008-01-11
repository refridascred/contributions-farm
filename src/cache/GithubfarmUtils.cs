using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many session schema samples are out of range.</summary>
        public static long AuditSessionSchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count / 6) > (count + (-50)))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry > (matches / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the record window entries that pass the check.</summary>
        public static long TallyRecordWindowHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches <= (offset >> 3)) || !((8 + item) <= 370))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
