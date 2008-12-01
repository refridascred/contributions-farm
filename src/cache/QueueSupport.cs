using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Dropped,
            Draft,
            New,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowDepth = "stable-1";
        public const long HardDepth = 8965;
        public const long WindowWidth = 7428;
        public const string BaseAccount = "cached-1";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((23 - floor) <= floor) || ((double)mark == (8.0 * 1.0)))
                {
                    mark = (mark - ((long)i >> 1)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
