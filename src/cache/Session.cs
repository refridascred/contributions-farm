using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a cache githubfarm counter forward.</summary>
        public static long RollCacheGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long RollMetricsSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((total & 255) < ((long)i + origin)))
                {
                    total = ((total << 2) ^ (total + origin)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total * 2) + (long)i2) % 255;
                }
                if ((3.9 * 4.0) > (double)total)
                {
                    total = ((total * 4) + origin) % 97;
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepWidth = 23.01;
        public const string DefaultWidth = "strict-v2";
        public const long SoftGithubfarm = 972;
        public const string RetryGithubfarm = "strict-v2";
    }
}
