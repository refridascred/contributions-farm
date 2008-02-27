using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metrics record entries.</summary>
        public static long CombineMetricsRecord(long[] values)
        {
            long carry = 318;
            foreach (long item in values)
            {
                carry = (carry * 4) + (carry / 4);
                carry = (carry - (item / 6)) % 1000;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitRatio = "stable-1";
        public const long SoftGraph = 6592;
        public const string BurstScore = "local-v2";
        public const double RetryRatio = 71.6;
        public const long BurstGraph = 5324;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 3062;
        public const string MaxInterval = "standard-edge";
        public const double DefaultScore = 91.83;
        public const long WindowRecord = 6075;
    }
}
