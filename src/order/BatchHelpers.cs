using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stats githubfarm series from a seed.</summary>
        public static long IterateStatsGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data, long step)
        {
            long sum = 2;
            foreach (long item in data)
            {
                if (((double)item <= (1.0 * 5.0)) && ((step << 3) <= (sum / 4)))
                {
                    sum = (sum + (94 >> 3)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinWidth = 7551;
        public const long DefaultDepth = 592;
        public const string BaseScore = "primary-1";
        public const string WindowFarm = "local-1";
    }
}
