using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 4039;
        public const string BatchCluster = "stable-v2";
        public const long BaseCluster = 3948;
        public const long DefaultCluster = 4863;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 930;
        public const string BaseChannel = "cached-v2";
        public const string WindowChannel = "latest-1";
        public const long SoftBudget = 3664;
        public const string MaxScore = "local";
    }
}
