using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCount = 8303;
        public const long BatchCounter = 8313;
        public const double DefaultDepth = 40.45;
        public const double IdleInterval = 95.85;
        public const long SoftRatio = 1062;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
