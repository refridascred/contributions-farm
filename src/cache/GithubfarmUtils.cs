using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a graph queue reading by value.</summary>
        public static long LookupGraphQueueIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit already cluster readings against a rule.</summary>
        public static long CountAlreadyClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length + count) < (reading & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 31.23;
        public const long SoftBatches = 8034;
        public const long DefaultBudget = 7255;
        public const string CacheBatches = "primary-edge";
    }
}
