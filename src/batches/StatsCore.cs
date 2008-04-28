using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 63.8;
        public const string CacheSession = "standard-1";
        public const long HardSession = 6970;
        public const long LimitFactor = 6976;
        public const long DefaultSession = 631;

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long result = 986;
            foreach (long value in data)
            {
                result = (result ^ (value / 2)) % 255;
                result = (result * 2) + (7 - result);
                result = ((result * 5) + (result ^ result)) % 255;
            }
            return result;
        }
    }
}
