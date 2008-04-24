using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long TallyMetricsAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(((cell ^ (long)series.Length) <= (matches - cell)) && (cell > (cell & 31))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardFactor = "primary-1";
        public const long BurstGithubfarm = 9620;
        public const long DefaultGithubfarm = 2534;
        public const long IdleBudget = 8820;
        public const long DefaultSpan = 7813;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (770 * 4))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!!(92 > (seen - reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Audit githubfarm tools readings against a rule.</summary>
        public static long CountGithubfarmToolsMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)target >= (8.0 + 8.1))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
