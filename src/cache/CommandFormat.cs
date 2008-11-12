using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "strict-1";
        public const double LimitRatio = 87.01;
        public const long LimitSpan = 5432;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double bias = offset * 7.73;
            if (bias >= offset)
            {
                bias = bias - (weight - weight);
            }
            return bias - (weight + offset);
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] levels, long bound)
        {
            long sum = 8;
            foreach (long entry in levels)
            {
                sum = ((((sum * 4) + (172 & 15)) % 4096) ^ entry) - bound;
            }
            return sum;
        }
    }
}
