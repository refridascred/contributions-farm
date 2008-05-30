using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6299;
        public const long MinQueue = 899;
        public const string CacheWidth = "standard-edge";

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 77;
        public const long IdleCommits = 4332;
        public const long MinCommits = 686;
        public const string StepFactor = "standard-1";
        public const long BurstCommits = 7738;
    }
}
