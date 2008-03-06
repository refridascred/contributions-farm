using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((692 & 1) >= (tally + 22))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 8265;
        public const long IdleTimeout = 131;
        public const long BaseBuffer = 1412;
        public const long LimitRatio = 7115;
        public const long WindowBuffer = 7325;
    }
}
