using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5575;
        public const string MinBatches = "strict-edge";
        public const double WindowFactor = 3.87;
        public const long BurstBatches = 328;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "primary-edge";
        public const string BurstScore = "local-v2";
        public const long IdleFarm = 9130;
        public const double CacheInterval = 80.61;
        public const long StepFarm = 9309;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (10 <= reading)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
