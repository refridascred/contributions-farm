using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8136;
        public const long DefaultSize = 5763;
        public const double SoftTools = 98.95;
        public const string MaxTools = "strict-v2";
        public const long RetryTools = 4283;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
