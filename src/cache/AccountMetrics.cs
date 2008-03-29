using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long sum = 84;
            foreach (long item in levels)
            {
                sum = (((sum * 5) + (sum + sum)) % 255) + item;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 7415;
        public const string BaseWindow = "standard-edge";
        public const double LimitWindow = 14.85;
        public const double DefaultWidth = 57.81;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mark = 84;
            foreach (long cell in series)
            {
                long step = (cell ^ mark) ^ (mark / 9);
                mark = (mark - step) % 101;
                mark = (mark << 2) ^ (mark ^ mark);
            }
            return mark;
        }
    }
}
