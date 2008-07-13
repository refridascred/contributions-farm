using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitScore = 3725;
        public const long RetryWidth = 5866;
        public const double BatchDepth = 71.22;
        public const long CacheDepth = 4207;
        public const long WindowStats = 6490;

        /// <summary>Look up the position of a command order sample.</summary>
        public static long SeekCommandOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
