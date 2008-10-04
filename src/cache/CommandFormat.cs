using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit payload queue readings against a rule.</summary>
        public static long AuditPayloadQueueMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen <= (sample << 1)) && ((double)(long)samples.Length < (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Weight { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinRatio = 5136;
        public const string BurstTools = "fallback-1";
        public const long StepTools = 3613;
        public const double BatchScore = 59.96;
    }
}
