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

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score + (51 - score)) % 4096) + (long)i2;
                }
                if (!(((17 / 3) < (long)i) && ((double)score >= (12.0 * 14.0))))
                {
                    score = (score * 5) + ((long)i << 1);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
