using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 86.04;
        public const long RetryFormat = 1776;
        public const long StepFormat = 7610;
        public const string HardFormat = "strict-edge";
        public const long DefaultWidth = 4978;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
