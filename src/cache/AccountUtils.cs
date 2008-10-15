using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
