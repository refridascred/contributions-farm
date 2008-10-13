using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell * 5) != ((long)samples.Length + cell)) || ((2.8 + 8.3) > (double)cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 4989;
        public const long BatchGithubfarm = 8170;
        public const string SoftGithubfarm = "primary-v2";
    }
}
