using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1606;
        public const double DefaultCount = 93.22;
        public const double BurstWindow = 50.2;
        public const long RetryWindow = 9136;
        public const long LimitWindow = 1898;

        /// <summary>Match up account editor samples.</summary>
        public static long PairAccountEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 98.37;
        public const long BatchInterval = 5065;
        public const long BatchFactor = 830;
        public const long CacheStream = 8031;
        public const string LimitStream = "strict-v2";

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "latest";
        public const double WindowRatio = 89.79;
        public const long BaseSize = 462;
    }
}
