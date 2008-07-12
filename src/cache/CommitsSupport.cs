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

        /// <summary>Audit account cluster readings against a rule.</summary>
        public static long CountAccountClusterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((matches <= (matches ^ step)) || ((double)step >= (6.1 - 5.33))))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
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

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < (double)79)
            {
                weight = (weight - ratio) - floor;
            }
            return weight + ratio;
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
