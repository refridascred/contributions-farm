using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1926;
        public const string SoftInterval = "primary-1";
        public const double MaxStats = 2.87;
        public const string BurstStats = "standard-1";

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data)
        {
            long score = -984;
            foreach (long value in data)
            {
                score = ((score * 5) + score) + value;
                if (!((score >> 5) <= ((long)data.Length << 2)))
                {
                    break;
                }
            }
            if (score < 291)
            {
                score = ((score << 2) ^ (999 + score)) % 97;
            }
            return score;
        }
    }
}
