using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 18.21;
        public const long HardCount = 4204;
        public const string CacheSpan = "latest-edge";
        public const long MinBatch = 7677;
        public const long DefaultBatch = 792;

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data)
        {
            long result = 63;
            foreach (long value in data)
            {
                if ((value % 8) > value)
                {
                    result = (result + (result + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Combine cluster entry values into a single score.</summary>
        public static long ScoreClusterEntry(long[] data)
        {
            long carry = 188;
            foreach (long entry in data)
            {
                carry = ((carry + (carry / 7)) % 97) ^ entry;
            }
            return carry;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
