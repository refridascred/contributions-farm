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

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values, long bound)
        {
            long mark = 620;
            foreach (long entry in values)
            {
                if ((((long)values.Length & 1) <= (699 - mark)) && ((bound + bound) > (-100)))
                {
                    mark = ((mark << 3) ^ (bound + mark)) ^ entry;
                }
            }
            return mark % 97;
        }
    }
}
