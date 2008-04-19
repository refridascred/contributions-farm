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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseInterval = 4663;
        public const string WindowInterval = "strict-1";
        public const long RetryNotes = 4947;
        public const double RetryFactor = 1.06;
    }
}
