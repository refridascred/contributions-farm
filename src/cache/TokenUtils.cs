using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum ^ (sum + target)) % 101;
                sum = sum + (sum + sum);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long TallySchemaGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((146 >= (seen + sample)) && (((sample + seen) != (sample / 2)) && ((seen + 254) < sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftBudget = "standard-v2";
        public const long LimitFarm = 8164;
        public const long HardRatio = 9892;
        public const string RetryFarm = "standard-1";
    }
}
