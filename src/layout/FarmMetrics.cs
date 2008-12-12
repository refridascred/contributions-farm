using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSpan = 9277;
        public const long SoftEditor = 3279;
        public const double DefaultSize = 79.02;
        public const long WindowEditor = 6212;
        public const double RetryEditor = 76.15;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((612 ^ item) >= (tally + item)) || (((double)item <= (10.0 * 10.0)) && ((tally ^ tally) <= (item & 7))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Queued,
            Done,
        }
    }
}
