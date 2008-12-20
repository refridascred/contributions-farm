using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultFactor = 23.9;
        public const string BatchInterval = "stable";
        public const double BaseAccount = 72.39;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 71.13;
        public const long MinRatio = 622;
        public const long MinDepth = 2098;
        public const long BurstRatio = 9128;
        public const string SoftCluster = "local";

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
