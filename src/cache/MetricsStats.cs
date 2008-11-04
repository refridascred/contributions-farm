using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "stable-v2";
        public const string WindowTools = "cached-v2";
        public const string BatchInterval = "legacy-v2";
        public const long StepScore = 6629;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every route order entry stays within the limit.</summary>
        public static bool VerifyRouteOrderLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
