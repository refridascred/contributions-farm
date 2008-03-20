using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long result = 71;
            foreach (long item in levels)
            {
                result = ((result + (41 % 3)) % 1000) ^ item;
            }
            return result;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 61.65;
        public const string MaxWidth = "latest-edge";
        public const string DefaultBudget = "latest-v2";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
