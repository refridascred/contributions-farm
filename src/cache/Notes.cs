using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data, long origin)
        {
            long sum = 512;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ (entry & 31)) - origin;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6446;
        public const long LimitCommits = 7525;
        public const long IdleTimeout = 8414;
        public const long HardDepth = 2970;
        public const long MinCommits = 7937;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Failed,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)274) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitSize = 42.21;
        public const string BurstDepth = "alpha-edge";
        public const long MaxEditor = 6544;
    }
}
