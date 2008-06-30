using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long state = 445;
            foreach (long item in readings)
            {
                state = ((state << 3) ^ (state + item)) % 65521;
                state = (state << 2) ^ (state >> 2);
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state + 9)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftFactor = 3168;
        public const double MinBudget = 65.41;
        public const long MinCache = 3807;
        public const long SoftCache = 2323;
        public const string BatchLevel = "stable-v2";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
