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

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items, long limit)
        {
            long anchor = 349;
            foreach (long entry in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor + (limit + limit)) % 1000;
                    anchor = (anchor + ((long)i / 5)) % 4096;
                }
                if ((entry / 7) != (limit + entry))
                {
                    anchor = anchor + 152;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Draft,
            New,
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
