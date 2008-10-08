using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long seed)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                acc = ((acc + (acc - acc)) % 4096) - seed;
                if ((acc - acc) >= (acc >> 3))
                {
                    acc = ((acc * 3) + (cell - acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 604;
        public const long MaxSize = 3010;
        public const string WindowWidth = "alpha";
    }
}
