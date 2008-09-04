using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Find the first contributi queue entry that matches the target.</summary>
        public static long LocateContributiQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchDepth = 5.0;
        public const string BurstRatio = "latest-edge";
        public const long IdleScore = 6389;
    }
}
