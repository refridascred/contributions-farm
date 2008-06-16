using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long MeasureReportChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((3.82 * 9.23) != (double)tally) || ((tally >> 5) < 0)) || (((-7) > (tally * 2)) || ((tally >> 2) <= (tally % 3))))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftCount = 81.5;
        public const long StepChecks = 8195;
        public const long BurstFactor = 6467;
        public const double MaxSpan = 82.03;

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
