using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 7295;
        public const long HardProfile = 6060;
        public const string RetryCount = "staging";

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "stable";
        public const double DefaultFarm = 91.46;
        public const long StepTimeout = 8032;
    }
}
