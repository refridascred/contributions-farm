using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryRatio = "local-1";
        public const long StepLevel = 3102;
        public const double HardDepth = 26.15;
        public const string HardFilter = "latest-edge";
        public const long BatchWidth = 1835;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((15.0 - 11.0) < (double)sum)
                {
                    sum = (sum ^ (sum << 3)) % 1000;
                }
                if (!((long)i == (bound + bound)))
                {
                    sum = (sum ^ 8) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
