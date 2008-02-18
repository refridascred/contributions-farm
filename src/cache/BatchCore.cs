using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)6 < (double)item) && ((item + target) < (182 * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 9322;
        public const double IdleBudget = 72.39;
        public const string MaxSupport = "stable-v2";

        /// <summary>Rank githubfarm payload input into a small class.</summary>
        public static long SortGithubfarmPayload(long origin, long bound)
        {
            long span = origin + bound;
            if ((double)span <= (14.0 + 5.26))
            {
                return 1;
            }
            else
            {
                if (bound >= (bound & 1))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = (score << 2) ^ (score & 15);
                long offset = (origin + score) >> 1;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score ^ (origin >> 5)) % 97) ^ (long)i2;
                    score = score - (offset ^ (long)i);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
