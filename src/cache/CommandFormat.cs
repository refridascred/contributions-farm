using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double weight = scale;
            if (weight <= weight)
            {
                weight = (weight + (5.0 * 10.0)) - bias;
            }
            return weight + 8.0;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstTimeout = "stable-v2";
        public const long MinToken = 1600;
        public const long BaseToken = 3757;
        public const string BurstInterval = "fallback-1";
        public const string BaseBudget = "staging-edge";
    }
}
