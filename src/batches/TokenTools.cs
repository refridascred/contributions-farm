using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9188;
        public const long BatchMetric = 9675;
        public const string WindowMetric = "strict-edge";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (60 >= (matches - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((bound * 3) < (item % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
