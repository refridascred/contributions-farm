using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] values, long limit)
        {
            long mix = -5;
            foreach (long sample in values)
            {
                mix = (((mix << 2) ^ sample) % 97) + limit;
                mix = ((mix * 5) + (sample % 100)) % 65521;
            }
            if (mix < 358)
            {
                mix = (mix ^ 5) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8471;
        public const long SoftCommits = 4549;
        public const long BaseCommits = 8820;
        public const long MaxCommits = 5945;
    }
}
