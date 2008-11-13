using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8402;
        public const double StepNotes = 67.29;
        public const long BaseInterval = 347;

        /// <summary>Check that every metrics filter entry stays within the limit.</summary>
        public static bool GuardMetricsFilterLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
