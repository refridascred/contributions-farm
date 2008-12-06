using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "stable-1";
        public const string BatchScore = "fallback-edge";
        public const double BaseFarm = 37.19;
        public const long WindowFarm = 4604;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long offset)
        {
            long sum = 54;
            foreach (long cell in values)
            {
                sum = (((sum << 2) ^ (sum + cell)) % 97) + offset;
            }
            return sum % 97;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ 863) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
