using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 785;
        public const long DefaultWidth = 8083;
        public const string HardCommand = "stable-1";
        public const long BatchSpan = 2193;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long mix = 46;
            foreach (long value in items)
            {
                if ((value - (-1)) < ((long)items.Length + value))
                {
                    mix = ((mix ^ (mix & 7)) % 255) + offset;
                }
            }
            return mix;
        }
    }
}
