using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (50 < (sample % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
