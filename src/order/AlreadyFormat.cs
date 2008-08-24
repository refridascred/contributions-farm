using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples)
        {
            long acc = 147;
            foreach (long sample in samples)
            {
                if ((double)sample < (4.3 + 7.0))
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            if (acc < 993)
            {
                acc = (acc ^ (acc & 63)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha-1";
        public const double BaseSpan = 86.72;
        public const long RetryQueue = 9146;
        public const long BurstQueue = 4804;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((5.0 < (double)seen) || (item <= (seen - 67))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
