using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinBuffer = "local-1";
        public const long IdleBuffer = 8863;
        public const long BatchBuffer = 7366;
        public const double LimitBuffer = 33.11;
        public const string WindowBuffer = "stable-v2";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((3.7 / 6.0) == (double)seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
