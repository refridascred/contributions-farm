using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up context commits samples.</summary>
        public static long CompareContextCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseFactor = 4686;
        public const long MaxProfile = 1435;
        public const string RetryProfile = "local";

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitTimeout = "staging";
        public const string WindowCount = "staging";
        public const long BurstStream = 309;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
