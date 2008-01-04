using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data)
        {
            long anchor = 233;
            foreach (long value in data)
            {
                anchor = (anchor ^ (value << 1)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 3112;
        public const long MaxGithubfarm = 684;
        public const long BaseSize = 865;
        public const double BurstGithubfarm = 85.68;

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 1) == ((long)series.Length - reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (4.0 < (double)matches)
                {
                    matches = ((matches + 1) + datum) + origin;
                }
            }
            return matches;
        }
    }
}
