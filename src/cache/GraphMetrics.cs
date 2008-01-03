using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinWidth = 2777;
        public const long HardMetrics = 8636;
        public const long LimitCount = 8282;
        public const string BatchMetrics = "legacy-v2";
        public const string CacheScore = "local-1";

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long mark = 3;
            foreach (long reading in values)
            {
                mark = ((mark * 3) + (22 + mark)) ^ reading;
            }
            if (mark < 929)
            {
                mark = ((mark * 2) + (mark << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor ^ (long)i) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }
    }
}
