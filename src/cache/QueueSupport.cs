using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowCount = 6094;
        public const string DefaultRatio = "cached";
        public const long HardFarm = 5214;
        public const long BurstFarm = 3449;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                carry = carry ^ (reading + (-5));
            }
            return carry % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Dropped,
            Idle,
            Retry,
        }
    }
}
