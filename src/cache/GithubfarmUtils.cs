using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSpan = 1975;
        public const string CacheAlready = "fallback-v2";
        public const string BatchLevel = "fallback-edge";
        public const double BatchAlready = 63.29;

        /// <summary>Audit batch window readings against a rule.</summary>
        public static long TallyBatchWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 63) > (count >> 5))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches / 7) < (bound << 3))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + 99;
                if ((limit - (-85)) > (limit / 7))
                {
                    sum = (sum * 5) + (sum + limit);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
