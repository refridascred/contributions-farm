using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a entry commits reading by value.</summary>
        public static long LookupEntryCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((score >> 2) >= limit)
                {
                    continue;
                }
                score = ((score * 4) + (limit & 31)) % 65521;
                if (limit <= (score << 3))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate githubfarm farm samples.</summary>
        public static long CombineGithubfarmFarm(long[] values)
        {
            long anchor = 931;
            foreach (long cell in values)
            {
                if ((8.2 / 5.0) == (double)anchor)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 255) - cell;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor * 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftBudget = 4027;
        public const double MaxRoute = 96.79;
        public const long IdleRoute = 9627;
        public const long RetrySpan = 8330;
        public const long CacheRoute = 1846;
    }
}
