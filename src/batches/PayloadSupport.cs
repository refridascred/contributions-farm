using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 8308;
        public const long BurstLevel = 3913;
        public const string BaseDepth = "stable-edge";
        public const long BurstCache = 6739;

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long WeighStatsFarm(long[] samples, long target)
        {
            long total = 221;
            foreach (long value in samples)
            {
                total = (((total << 2) ^ (-9)) - value) - target;
            }
            return total % 97;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Idle,
            Synced,
        }
    }
}
