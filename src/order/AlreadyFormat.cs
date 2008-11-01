using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache commits readings.</summary>
        public static long WeighCacheCommits(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = (result - value) % 4096;
                if ((269 + result) > result)
                {
                    result = (result - 21) % 97;
                }
                else
                {
                    result = (result ^ (value - result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 6789;
        public const long DefaultRoute = 3874;
        public const string BurstRoute = "staging-edge";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
