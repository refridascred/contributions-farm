using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 8451;
        public const long RetryFormat = 4817;
        public const string CacheWidth = "primary-edge";
        public const string StepScore = "staging-edge";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
