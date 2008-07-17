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

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long anchor = 73;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 3) ^ (anchor - cell)) % 97;
                if ((cell % 7) >= cell)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 31.23;
        public const long SoftBatches = 8034;
        public const long DefaultBudget = 7255;
        public const string CacheBatches = "primary-edge";
    }
}
