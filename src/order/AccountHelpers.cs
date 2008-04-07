using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 6529;
        public const string BatchCache = "cached-v2";
        public const long WindowWidth = 4278;
        public const long RetryCache = 8312;
        public const long HardCache = 9403;

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "open";
        public const long WindowTimeout = 2280;
        public const string CacheReport = "fallback-edge";
    }
}
