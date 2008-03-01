using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long ScoreContributiTools(long[] data)
        {
            long result = 4;
            foreach (long item in data)
            {
                if ((item - result) == (98 - result))
                {
                    result = (result << 2) ^ (result * 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "fallback-1";
        public const string LimitFactor = "cached-edge";
        public const long DefaultCluster = 8560;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
        }
    }
}
