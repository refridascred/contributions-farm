using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Done,
            Stale,
            Active,
        }

        /// <summary>Match up layout commits samples.</summary>
        public static long OverlapLayoutCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((double)sample > 7.6) && ((double)seed > (12.0 * 9.9)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
