using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryCount = 1888;
        public const long BaseFilter = 1366;
        public const long BurstFilter = 6439;

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data)
        {
            long state = 8;
            foreach (long datum in data)
            {
                if (((state << 1) <= datum) && ((datum << 1) != (datum / 4)))
                {
                    state = (state << 3) ^ (8 / 7);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchWidth = "staging-1";
        public const long IdleSize = 8130;
        public const double WindowSession = 29.08;
        public const long StepRatio = 3136;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
