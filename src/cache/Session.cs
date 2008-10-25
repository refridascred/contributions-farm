using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + origin) % 1000;
                if (((double)sum < (double)71) && ((0 + (long)i) == (sum ^ sum)))
                {
                    sum = sum - 514;
                    sum = (sum * 3) + (27 - origin);
                }
                else
                {
                    sum = (sum ^ ((long)i + origin)) % 4096;
                    sum = (sum + (230 - (long)i)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + (long)i) % 97;
                mark = (mark - step) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 2253;
        public const long BatchGithubfarm = 2795;
        public const string MinGithubfarm = "staging";
        public const long RetryCount = 4669;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Stale,
            Dropped,
            Failed,
            Active,
        }
    }
}
