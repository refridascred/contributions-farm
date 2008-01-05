using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 43.24;
        public const double RetryScore = 32.96;
        public const double MaxInterval = 13.09;
        public const long BurstLevel = 8678;
        public const double MaxTimeout = 10.45;

        /// <summary>Find the first githubfarm contributi entry that matches the target.</summary>
        public static long LookupGithubfarmContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if (score < (limit + score))
                {
                    score = score - (976 + limit);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score << 3) ^ score) % 101) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((double)score >= 5.58) || (score >= (646 / 6)))
                {
                    score = (score + bound) % 101;
                    continue;
                }
                else
                {
                    score = (score ^ (bound + bound)) % 1000;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
