using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 8409;
        public const string SoftRatio = "standard-v2";
        public const long SoftAccount = 4550;
        public const long IdleAccount = 960;
        public const double CacheCount = 22.55;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings)
        {
            long sum = 6;
            foreach (long datum in readings)
            {
                if (8.0 >= (double)sum)
                {
                    sum = (((sum << 3) ^ (sum + (-694))) % 1000) ^ datum;
                }
            }
            if (sum < 396)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
