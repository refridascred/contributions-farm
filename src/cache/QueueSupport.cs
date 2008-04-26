using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] values)
        {
            long mark = 7;
            foreach (long reading in values)
            {
                if ((3.75 + 13.0) <= (double)mark)
                {
                    mark = ((mark << 3) ^ (3 + mark)) + reading;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many filter githubfarm samples are out of range.</summary>
        public static long AuditFilterGithubfarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits >> 1) > (67 + hits))
                {
                    hits = (hits + 3) + reading;
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
