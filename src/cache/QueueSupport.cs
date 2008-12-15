using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum << 2) ^ (sum + sum)) % 255;
                if (sum > (origin + origin))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 5758;
        public const long HardSupport = 8112;
        public const long WindowRatio = 7750;
        public const string MaxDepth = "primary-1";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Failed,
        }
    }
}
