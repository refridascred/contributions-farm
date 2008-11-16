using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Dropped,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 11.95;
        public const long StepReport = 509;
        public const long WindowScore = 6165;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((4.9 / 3.0) != (double)matches) && ((matches < (sample & 127)) || (matches > (matches - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches ^ value) < (value + matches)) || ((0.66 - 4.8) == (double)value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
