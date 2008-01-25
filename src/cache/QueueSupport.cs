using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleScore = 65.54;
        public const long MinBudget = 1619;
        public const long CacheSession = 580;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowRatio = 25.26;
        public const double HardGithubfarm = 91.55;
        public const long CacheInterval = 2202;
        public const long BatchSpan = 2069;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items, long target)
        {
            long result = -13;
            foreach (long sample in items)
            {
                result = (result - (sample >> 4)) % 255;
                result = (result ^ (target & 127)) % 65521;
            }
            if (result > 97)
            {
                result = ((result << 3) ^ (target << 1)) % 65521;
            }
            return result % 65521;
        }
    }
}
