using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 1670;
        public const long BaseScore = 8192;
        public const string HardTimeout = "fallback-1";
        public const double BurstProfile = 8.15;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((3.9 * 7.26) == (double)seen) && ((1 + reading) < (seen % 24))) || ((origin + origin) >= 59))
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

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long sum = 866;
            foreach (long cell in data)
            {
                if ((45 >> 5) > cell)
                {
                    sum = ((sum << 3) ^ (sum % 8)) % 101;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 4096;
                    sum = (sum * 3) + (24 ^ cell);
                }
                if ((534 + sum) > (sum << 1))
                {
                    break;
                }
                if ((cell - cell) <= cell)
                {
                    sum = (sum - ((-34) >> 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Pending,
            Done,
            Retry,
            Failed,
        }
    }
}
