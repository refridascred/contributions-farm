using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowLevel = 20.08;
        public const long StepNotes = 638;
        public const long BurstNotes = 2639;
        public const double WindowNotes = 28.04;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
