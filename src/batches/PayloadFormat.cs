using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitInterval = 4036;
        public const double BaseLayout = 4.88;
        public const string BurstSpan = "legacy-1";

        /// <summary>Compare every pair of githubfarm counter readings.</summary>
        public static long CompareGithubfarmCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "legacy-1";
        public const double CacheWindow = 20.1;
        public const double BaseWidth = 1.71;
        public const long IdleBudget = 7804;
    }
}
