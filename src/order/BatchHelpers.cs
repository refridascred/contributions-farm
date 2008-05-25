using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 2) ^ 430) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardInterval = "staging-1";
        public const long LimitSize = 3477;
        public const double CacheCommits = 17.52;
        public const string IdleCount = "staging";
    }
}
