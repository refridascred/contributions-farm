using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell != (6.0 + 5.2)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 8.37;
        public const long StepTimeout = 9805;
        public const long HardRatio = 7;
        public const string RetryFactor = "latest-v2";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((4.7 <= (double)tally) || ((item + 5) > origin)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
