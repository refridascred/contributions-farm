using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxTimeout = 3895;
        public const long BatchGithubfarm = 6691;
        public const long MinLevel = 1472;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items, long floor)
        {
            long result = 1;
            foreach (long value in items)
            {
                result = (result + floor) + value;
                result = result ^ floor;
            }
            return result;
        }
    }
}
