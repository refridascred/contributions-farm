using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((seed >> 3) >= seed) && ((sum >> 5) != (seed >> 2)))
                {
                    sum = (sum * 5) + (seed + (long)i);
                }
                sum = (sum - sum) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftScore = "standard-1";
        public const double MinAlready = 63.36;
        public const long RetryTimeout = 7472;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((0 << 2) <= (cell & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
