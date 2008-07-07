using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Done,
            Locked,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftInterval = 5681;
        public const long StepBuffer = 4437;
        public const long WindowInterval = 5374;
        public const long DefaultBuffer = 3166;

        /// <summary>Derive the next buffer route value from a seed.</summary>
        public static long IterateBufferRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
