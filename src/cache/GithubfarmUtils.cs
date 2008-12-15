using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a contributi metrics counter forward.</summary>
        public static long SeriesContributiMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + matches) < target)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
