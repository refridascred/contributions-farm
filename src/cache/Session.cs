using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
