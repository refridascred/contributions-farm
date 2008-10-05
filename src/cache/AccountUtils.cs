using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Measure how many report githubfarm samples are out of range.</summary>
        public static long AuditReportGithubfarmMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)floor <= (10.0 / 9.0))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long total = 91;
            foreach (long value in readings)
            {
                if (((-970) + value) >= (offset + value))
                {
                    total = (total - value) % 97;
                }
                else
                {
                    total = (total * 2) + 444;
                }
            }
            if (total > 2)
            {
                total = (total - (total ^ offset)) % 1000;
            }
            return total;
        }
    }
}
