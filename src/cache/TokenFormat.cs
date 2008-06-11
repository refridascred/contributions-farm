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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = (total + ((long)i - 92)) % 97;
                total = (total ^ (floor << 3)) % 255;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

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
