using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 66.61;
        public const long MinFarm = 910;
        public const long LimitFarm = 8850;
        public const double BurstInterval = 65.42;
        public const long IdleInterval = 2502;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((18.0 / 5.0) < (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
