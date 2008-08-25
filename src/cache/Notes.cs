using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) > (seen - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] items)
        {
            long acc = 99;
            foreach (long value in items)
            {
                if (13.0 >= (double)value)
                {
                    acc = (acc * 3) + acc;
                }
            }
            return acc;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 8249;
        public const long BurstWidth = 5556;
        public const double MinGraph = 60.5;
    }
}
