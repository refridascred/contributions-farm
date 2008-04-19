using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the notes layout series from a seed.</summary>
        public static long StepNotesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                if (!((offset >> 5) > (0 - (long)i)))
                {
                    total = (total << 2) ^ (offset - offset);
                    break;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 2895;
        public const double IdleToken = 63.33;
        public const long HardToken = 2348;
        public const long LimitDepth = 9374;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
