using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheFactor = 5747;
        public const long SoftSchema = 9375;
        public const long LimitSchema = 1656;
        public const long CacheSize = 4497;
        public const long RetrySchema = 857;

        /// <summary>Count the profile githubfarm entries that pass the check.</summary>
        public static long AuditProfileGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + item) == (hits + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine report queue values into a single score.</summary>
        public static long TotalReportQueue(long[] data)
        {
            long anchor = 80;
            foreach (long cell in data)
            {
                anchor = (anchor - cell) % 101;
                if ((277 / 2) > (cell * 4))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
