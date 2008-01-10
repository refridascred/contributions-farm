using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 5162;
        public const double MinMetrics = 27.33;
        public const long StepMetrics = 2187;

        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long CountSchemaFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen >> 4) >= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
