using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)80)
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "latest-v2";
        public const string BaseCommits = "strict-edge";
        public const long DefaultLevel = 1767;
        public const long BurstCommits = 8382;
        public const long MinCommits = 3767;
    }
}
