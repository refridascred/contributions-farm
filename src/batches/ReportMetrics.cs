using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
