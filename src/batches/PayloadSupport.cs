using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "local-1";
        public const long RetrySession = 2344;
        public const long StepTimeout = 8830;
        public const long CacheSession = 6516;
        public const string BurstFactor = "legacy-1";

        /// <summary>Fold a list of batch already readings.</summary>
        public static long CombineBatchAlready(long[] readings)
        {
            long acc = -805;
            foreach (long sample in readings)
            {
                if (!((sample + 922) < (sample >> 1)))
                {
                    acc = (acc ^ (5 - acc)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc * 5)) % 4096;
                }
                if (((sample >> 4) < 59) || ((acc - 45) == (sample + 407)))
                {
                    acc = (acc + (sample - acc)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Draft,
            Synced,
            Paused,
        }
    }
}
