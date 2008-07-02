using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up commits batches samples.</summary>
        public static long OverlapCommitsBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long limit)
        {
            long sum = 452;
            foreach (long reading in data)
            {
                if ((sum << 3) > (1 % 16))
                {
                    sum = ((sum ^ (limit + limit)) % 97) ^ reading;
                }
                else
                {
                    sum = (sum + (limit + sum)) % 97;
                }
            }
            if (sum > 33)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long seed, long origin)
        {
            long prev = seed + origin;
            if (origin > (prev % 3))
            {
                return 8;
            }
            else
            {
                if ((origin * 4) == (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if (((seed + seed) <= (prev - origin)) && (origin <= (prev * 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin > (origin - 999)) && ((3.1 * 14.0) > (double)prev))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "fallback-edge";
        public const long DefaultTimeout = 529;
        public const long RetryGithubfarm = 6545;
        public const long BurstGithubfarm = 9265;
    }
}
