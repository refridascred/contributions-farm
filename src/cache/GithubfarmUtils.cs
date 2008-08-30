using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of layout queue readings.</summary>
        public static long MatchLayoutQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardDepth = "local";
        public const string BaseSpan = "latest-edge";
        public const double LimitLayout = 90.17;
        public const string CacheLayout = "local-edge";
        public const string BurstInterval = "open-v2";

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Idle,
            New,
            Synced,
            Closed,
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long AuditAccountSchemaGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)floor >= (double)hits)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}
