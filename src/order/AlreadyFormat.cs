using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Failed,
            Active,
            New,
            Ready,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 775;
        public const long MaxTimeout = 7303;
        public const string WindowRatio = "standard";
        public const long BatchSize = 927;
        public const string WindowReport = "stable-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstCount = 9291;
        public const long CacheFilter = 6085;
        public const long IdleFilter = 7193;
        public const long StepCount = 3955;

        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long DeriveFarmTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
